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
            return View();
        }
    }
}