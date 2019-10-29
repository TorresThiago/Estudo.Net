using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj03.Controles;
using Proj03.Entidades;

namespace Proj03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(1, "Thiago");
            Produto prod = new Produto(1, "Mouse", 25);

            PessoaControleImpressao pprint= new PessoaControleImpressao();
            pprint.ImprimirDados(p);

            ProdutoControleImpressao prodprint = new ProdutoControleImpressao();
            prodprint.ImprimirDados(prod);

            Console.ReadKey();

        }
    }
}
