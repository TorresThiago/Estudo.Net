using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Projeto.WEB.Validations
{
    //Regra 1) Herdar ValidationAttribute
    public class UploadFotoValidation : ValidationAttribute
    {
        //Regra 2) Sobrescrever (override) o método IsValid
        public override bool IsValid(object value)
        {
            //Verificar o Tipo do parametro value
            if (value != null && value is HttpPostedFileBase)
            {
                //verificar o tipo HttpPostedFileBase
                HttpPostedFileBase arquivo = (HttpPostedFileBase) value;

                //Obter a extensao do arquivo
                string extensao = Path.GetExtension(arquivo.FileName);

                //Testando
                return extensao.Equals(".jpg") || extensao.Equals(".jpeg") || extensao.Equals(".png") || extensao.Equals(".gif");
            }
            return true;
        }
    }
}