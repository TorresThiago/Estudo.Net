using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj03.Contratos;
using Proj03.Entidades;


namespace Proj03.Controles
{
    public class ProdutoControleImpressao : IControleImpressao<Produto>
    {
        public void ImprimirDados(Produto obj)
        {
            Console.WriteLine("Id do produto.......:" + obj.IdProduto);
            Console.WriteLine("Nome do produto.....:" + obj.Nome);
            Console.WriteLine("Preço do produto....:" + obj.Preco);
        }
    }
}
