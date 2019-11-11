using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.WEB.Models
{
    public class EstoqueConsultaModel
    {
        public int IdEstoque { get; set; }
        public string  Nome { get; set; }
        public string Descricao { get; set; }
        public int IdTipo { get; set; }
        public string Tipo { get; set; }
    }
}