using Projeto.DAL.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Entities
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoEstoque Tipo { get; set; }

        public Estoque()
        {

        }

        public Estoque(int idEstoque, string nome, string descricao, TipoEstoque tipo)
        {
            IdEstoque = idEstoque;
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Id estoque: {IdEstoque}, Nome: {Nome}, Descrição: {Descricao}, Tipo: {Tipo}";
        }
    }
}
