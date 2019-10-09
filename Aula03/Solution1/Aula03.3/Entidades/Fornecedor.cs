using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._3.Entidades
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string Nome{ get; set; }

        public List<Produto> Produtos { get; set; }

        public Fornecedor()
        {
            
        }

        public Fornecedor(int idFornecedor, string nome)
        {
            IdFornecedor = idFornecedor;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id: {IdFornecedor}, Nome: {Nome}";
        }
    }
}
