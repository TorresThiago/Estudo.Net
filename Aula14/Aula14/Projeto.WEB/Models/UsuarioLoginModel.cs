using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.WEB.Models
{
    public class UsuarioLoginModel
    {
        [Required(ErrorMessage ="Informe seu Login.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua Senha.")]
        public string Senha { get; set; }
    }
}