using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03._2.Entidade
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public String Nome { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int idPessoa, string nome)
        {
            IdPessoa = idPessoa;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Id Pessoa: {IdPessoa}, Nome: {Nome}";
        }
    }
}
