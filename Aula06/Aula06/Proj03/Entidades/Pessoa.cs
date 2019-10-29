using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj03.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
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
