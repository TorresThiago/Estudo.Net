using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//Mapeamentos
using Projeto.WEB.Validations;

namespace Projeto.WEB.Models
{
    public class ClienteCadastroModel
    {
        [MinLength(6,ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(50,ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do Cliente.")]
        public string Nome { get; set; }

        [EmailUnicoValidation(ErrorMessage = "E-mail já cadastrado.")]
        [Required(ErrorMessage = "Por favor, informe um e-mail do Cliente.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um e-mail válido.")]        
        public string Email { get; set; }
    }
}