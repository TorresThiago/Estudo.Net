using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Projeto.WEB.Validations;

namespace Projeto.WEB.Models
{
    public class UsuarioCadastroModel
    {
        [Required(ErrorMessage ="Informe o Nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Login.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a Senha.")]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage ="Senhas não conferem.")]
        [Required(ErrorMessage = "Confirme a Senha.")]
        public string SenhaConfirm { get; set; }

        [UploadFotoValidation(ErrorMessage = "Envie apenas imagens.")]
        [Required(ErrorMessage = "Envie a Foto.")]        
        public HttpPostedFileBase Foto { get; set; }
    }
}