using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03._3.Entidades;

namespace Aula03._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor(1, "Loja de Informatica");

            f.Produtos = new List<Produto>();

            Produto p1 = new Produto(1,"Abajur", 25, 10);
            Produto p2 = new Produto(2, "Quadro", 30, 50);
            Produto p3 = new Produto(3, "Mesa", 150, 10);

            f.Produtos.Add(p1);
            f.Produtos.Add(p2);
            f.Produtos.Add(p3);

            Console.WriteLine("Fornecedor: " + f.ToString());
            foreach(Produto p in f.Produtos)
            {
                Console.WriteLine("Produto: " + p.ToString());
            }

            int somatorioQuantidade = f.Produtos.Sum(p => p.Quantidade);
            decimal mediaPreco = f.Produtos.Average(p => p.Preco);
            decimal maiorPreco = f.Produtos.Min(p => p.Preco);
            decimal menorPreco = f.Produtos.Max(p => p.Preco);
            int qtdProdutos = f.Produtos.Count(p => p.Preco <= 30);

            Console.WriteLine("Somatório.......: " + somatorioQuantidade);            
            Console.WriteLine("Media de Preço..: " + mediaPreco);
            Console.WriteLine("Maior Preço.....: " + maiorPreco);
            Console.WriteLine("Menor Preço.....: " + menorPreco);
            Console.WriteLine("Produtos menores que 30......: " + qtdProdutos);            

            Console.ReadKey();
        }
    }
}
