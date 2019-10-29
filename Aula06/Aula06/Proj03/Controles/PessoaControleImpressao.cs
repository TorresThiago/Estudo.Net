using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj03.Contratos;
using Proj03.Entidades;

namespace Proj03.Controles
{
    public class PessoaControleImpressao : IControleImpressao<Pessoa>
    {
        public void ImprimirDados(Pessoa obj)
        {
            Console.WriteLine("\nDados da Pessoa: \n");

            Console.WriteLine("ID da Pessoa....: " + obj.IdPessoa);
            Console.WriteLine("Nome da Pessoa..: " + obj.Nome);         
        }
    }
}
