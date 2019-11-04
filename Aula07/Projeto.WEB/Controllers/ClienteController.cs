using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.WEB.Models;
using Projeto.DAL.Entities;
using Projeto.DAL.Repositories;

namespace Projeto.WEB.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Edicao(int idCliente)
        {
            ClienteEdicaoModel model = new ClienteEdicaoModel();

            try
            {
                ClienteRepository rep = new ClienteRepository();
                Cliente c = rep.FindById(idCliente);

                model.IdCliente = c.IdCliente;
                model.Nome = c.Nome;
                model.Email = c.Email;
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = e.Message;                
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Edicao(ClienteEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente c = new Cliente();
                    c.IdCliente = model.IdCliente;
                    c.Nome = model.Nome;
                    c.Email = model.Email;

                    ClienteRepository rep = new ClienteRepository();
                    rep.Update(c);
                    ViewBag.Mensagem = "Cliente atualizado com sucesso.";

                    List<ClienteConsultaModel> lista = ObterConsultaDeClientes();
                    return View("Consulta", lista);
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }
            return View();
        }

            public ActionResult Exclusao(int idCliente)
        {
            try
            {
                ClienteRepository rep = new ClienteRepository();

                rep.Delete(idCliente);

                ViewBag.Mensagem = "Cliente excluído com sucesso.";
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }
            List<ClienteConsultaModel> lista = ObterConsultaDeClientes();

            return View("Consulta", lista);
        }

        [HttpPost]
        public ActionResult Cadastro(ClienteCadastroModel model)
        {
            //verificar se os dados obtidos pela classe model
            //estão corretos (passaram nas validações?)
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente c = new Cliente();

                    c.Nome = model.Nome;
                    c.Email = model.Email;

                    ClienteRepository rep = new ClienteRepository();

                    rep.Insert(c);
                                       
                    //Criando msg q sera exibida na página
                    ViewBag.Mensagem = "Cliente cadastrado com sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = "Erro ao cadastrar Cliente - " + e.Message;
                }
                
            }
            return View();
        }

        public ActionResult Consulta()
        {
            List<ClienteConsultaModel> lista = ObterConsultaDeClientes();

            return View(lista);
        }

        private List<ClienteConsultaModel> ObterConsultaDeClientes()
        {
            List<ClienteConsultaModel> lista = new List<ClienteConsultaModel>();

            try
            {
                ClienteRepository rep = new ClienteRepository();
                List<Cliente> listagemCliente = rep.FindAll();

                foreach (Cliente c in listagemCliente)
                {
                    ClienteConsultaModel model = new ClienteConsultaModel();
                    model.IdCliente = c.IdCliente;
                    model.Nome = c.Nome;
                    model.Email = c.Email;
                    model.DataCadastro = c.DataCadastro;

                    lista.Add(model);
                }
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = "Erro ao consultar Cliente - " + e.Message;
            }

            return lista;
        }
    }
}