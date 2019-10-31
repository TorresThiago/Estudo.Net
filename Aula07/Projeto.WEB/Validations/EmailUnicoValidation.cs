using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Projeto.DAL.Repositories;

namespace Projeto.WEB.Validations
{
    public class EmailUnicoValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value != null && value is string)
            {
                string email = (string)value;

                ClienteRepository rep = new ClienteRepository();

                return !rep.HasEmail(email);
            }
            return false;            
        }
    }
}