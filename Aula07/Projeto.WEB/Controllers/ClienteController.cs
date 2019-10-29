using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.WEB.Models;

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
                //Criando msg q sera exibida na página
                ViewBag.Mensagem = "Cliente cadastrado com sucesso.";
            }
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }
    }
}