using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._3.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string  Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        //Associação (TER - 1)
        public Fornecedor Fornecedor { get; set; }

        public Produto()
        {
               
        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = IdProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"IdProduto: {IdProduto}, Nome: {Nome}, Preco: {Preco}, Quantidade: {Quantidade}";
        }


    }
}
