using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entidades;
using System.IO;

namespace ConsoleApp1.Controles
{
    public class ProdutoControle
    {
        public void ExportarProdTxt(Produto p)
        {
            StreamWriter sw = new StreamWriter("C:\\Produtos.txt");

            sw.WriteLine("ID: " + p.IdProduto);
            sw.WriteLine("Nome: " + p.Nome);
            sw.WriteLine("Preço: " + p.Preco);
            sw.WriteLine("Quantidade: " + p.Quantidade);

            sw.Close();
        }

        public void ExportarProdCSV(Produto p)
        {
            StreamWriter sw = new StreamWriter("C:\\arquivos\\Produtos.CSV");

            sw.WriteLine("{0};{1};{2};{3}",
                p.IdProduto,
                 p.Nome,
                 p.Preco,
                 p.Quantidade
                );
            
            sw.Close();
        }
    }
}
