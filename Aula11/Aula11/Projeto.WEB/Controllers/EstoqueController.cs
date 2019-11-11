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


        public JsonResult ConsultarEstoquePorId(int idEstoque)
        {
            try
            {   
                EstoqueRepositorio rep = new EstoqueRepositorio();
                EstoqueConsultaModel model = new EstoqueConsultaModel();
                Estoque e = rep.FindById(idEstoque);
                model.IdEstoque = e.IdEstoque;
                model.Nome = e.Nome;
                model.Descricao = e.Descricao;
                model.IdTipo = (int) e.Tipo;
                model.Tipo = e.Tipo.ToString();

                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult AtualizarEstoque(EstoqueEdicaoModel model)
        {
            try
            {
                Estoque e = new Estoque();
                e.IdEstoque = model.IdEstoque;
                e.Nome = model.Nome;
                e.Descricao = model.Descricao;
                e.Tipo = (TipoEstoque)model.Tipo;

                EstoqueRepositorio rep = new EstoqueRepositorio();
                rep.Update(e);

                return Json("Estoque atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult ExcluirEstoque(int idEstoque)
        {
            try
            {
                EstoqueRepositorio rep = new EstoqueRepositorio();
                rep.Delete(idEstoque);

                return Json("Estoque excluído com sucesso!");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

    }
}