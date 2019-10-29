using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj03.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Produto()
        {
        }
        public Produto(int idProduto, string nome, decimal preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
        }
        public override string ToString()
        {
            return $"Id Produto: {IdProduto}, Nome: {Nome}, Preço: {Preco}";
        }
    }
}
