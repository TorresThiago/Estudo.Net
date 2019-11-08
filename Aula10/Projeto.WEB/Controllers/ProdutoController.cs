using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.DAL.Entidades;
using Projeto.DAL.Repositorios;
using Projeto.WEB.Models;

namespace Projeto.WEB.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Cadastro()
        {
            return View();
        }

        public JsonResult CadastrarProduto(ProdutoCadastroModel produtoModel)
        {
            try
            {
                Produto p = new Produto();
                p.Nome = produtoModel.Nome;
                p.Preco = produtoModel.Preco;
                p.Quantidade = produtoModel.Quantidade;

                ProdutoRepositorio rep = new ProdutoRepositorio();
                rep.Insert(p);

                return Json($"Produto {p.Nome} cadastrado.");

            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
    }
}