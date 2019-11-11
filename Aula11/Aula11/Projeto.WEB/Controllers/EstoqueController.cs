using Projeto.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.DAL.Entities;
using Projeto.DAL.Entities.Types;
using Projeto.DAL.Repository;


namespace Projeto.WEB.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Estoque
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }

        public JsonResult CadastrarEstoque(EstoqueCadastroModel model)
        {
            try
            {
                Estoque e = new Estoque();
                EstoqueRepositorio rep = new EstoqueRepositorio();

                e.Nome = model.Nome;
                e.Descricao = model.Descricao;
                e.Tipo = (TipoEstoque)model.Tipo;

                rep.Insert(e);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }

            return Json("Estoque Cadastrado com sucesso");
        }

        public JsonResult ConsultarEstoques()
        {
            try
            {
                EstoqueRepositorio rep = new EstoqueRepositorio();
                List <EstoqueConsultaModel> lista = new List<EstoqueConsultaModel>();


                foreach (Estoque e in rep.BuscarTodos())
                {
                    EstoqueConsultaModel model = new EstoqueConsultaModel();
                    model.IdEstoque = e.IdEstoque;
                    model.Nome = e.Nome;
                    model.Descricao = e.Descricao;
                    model.Tipo = e.Tipo.ToString();

                    lista.Add(model);
                }
                return Json(lista,JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}