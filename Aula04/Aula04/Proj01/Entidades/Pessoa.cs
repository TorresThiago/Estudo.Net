using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj01.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int idPessoa, string nome, DateTime dataNascimento)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"Id Pessoa: {IdPessoa}, Nome: {Nome},Data de Nascimento: { DataNascimento}";
        }
    }
}
