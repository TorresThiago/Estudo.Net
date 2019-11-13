using Projeto.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.DAL;
using Projeto.Entidades;
using System.IO;

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
            if (ModelState.IsValid)
            {
                try
                {
                    //Buscar o usuario no banco de dados
                    UsuarioRepositorio rep = new UsuarioRepositorio();
                    Usuario u = rep.Find(model.Login, model.Senha);

                    if(u != null)
                    {
                        ViewBag.Mensagem = "Usuario encontrado.";
                    }
                    else
                    {
                        ViewBag.Mensagem = "Acesso Negado. Usuario não encontrado.";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;                    
                }
            }
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
            //verificar se os capos da model passaram na validação
            if (ModelState.IsValid)
            {
                try
                {
                    UsuarioRepositorio rep = new UsuarioRepositorio();

                    //verificar se o login do usuario ja foi cadastrado
                    if (! rep.HasLogin(model.Login))
                    {
                        //cadastrar o usuario
                        Usuario u = new Usuario();
                        u.Nome = model.Nome;
                        u.Login = model.Login;
                        u.Senha = model.Senha;
                        u.Foto = Guid.NewGuid().ToString() + Path.GetExtension(model.Foto.FileName);

                        rep.Insert(u);

                        //upload
                        string pasta = Server.MapPath("/Imagens/");
                        model.Foto.SaveAs(pasta + u.Foto);

                        ModelState.Clear();//Limpar campos do formulario
                        ViewBag.Mensagem = $"Usuario {u.Nome}, cadastrado com sucesso.";
                    }
                    else
                    {
                        ViewBag.Mensagem = "Erro. Este login já encontra-se cadastrado. Tente outro.";
                    }
                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            return View();
        }
    }
}