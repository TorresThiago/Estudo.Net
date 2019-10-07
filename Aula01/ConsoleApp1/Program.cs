using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entidades;
using ConsoleApp1.Controles;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudo Thiago");

            Produto p = new Produto();

            Console.WriteLine("Capturando Dados\n");
            Console.WriteLine("Id: ");
            p.IdProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Imprimindo Dados\n");
            Console.WriteLine("ID: " + p.IdProduto);
            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Preço: " + p.Preco);
            Console.WriteLine("Quantidade: " + p.Quantidade);


            Console.WriteLine("\nInforme 1 (TXT e 2 (CSV)");
            int opcao = int.Parse(Console.ReadLine());

            ProdutoControle pc = new ProdutoControle();

            switch (opcao)
            {
                case 1:
                    pc.ExportarProdTxt(p);
                    Console.WriteLine("Procudo exportado para TXT");
                    break;

                case 2:
                    pc.ExportarProdCSV(p);
                    Console.WriteLine("Procudo exportado para CSV");
                    break;
            }

            Console.ReadKey();
        }
    }
}
