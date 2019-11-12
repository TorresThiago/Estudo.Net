using Projeto.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.WEB.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        // GET: Usuario/Login
        [HttpPost]
        public ActionResult Login(UsuarioLoginModel model)
        {
            return View();
        }
        // GET: Usuario/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(UsuarioCadastroModel model)
        {
            return View();
        }
    }
}