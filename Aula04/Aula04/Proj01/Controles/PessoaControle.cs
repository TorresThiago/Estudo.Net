using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Entidades;
using Proj01.Repositorios;

namespace Proj01.Controle
{
    public class PessoaControle
    {
        public void CadastrarPessoa()
        {
            try
            {
                Console.WriteLine("\n :: Cadastro de Aluno :: \n");
                Pessoa p = new Pessoa();

                Console.WriteLine("Digite o nome: ");
                p.Nome = Console.ReadLine();

                Console.WriteLine("\nDigite a Data de Nascimento: \n");
                p.DataNascimento = DateTime.Parse(Console.ReadLine());

                PessoaRep prep = new PessoaRep();
                prep.Inserir(p);

                Console.WriteLine("\nPessoa cadastrada com sucesso! \n");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);                
            }
            
        }

        public void AtualizarPessoa()
        {
            try
            {
                Console.WriteLine("\n :: Atualização de Aluno :: \n");
                Pessoa p = new Pessoa();

                Console.WriteLine("Digite o Id: \n");
                p.IdPessoa = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome: \n");
                p.Nome = Console.ReadLine();

                Console.WriteLine("Digite a Data de Nascimento: \n");
                p.DataNascimento = DateTime.Parse(Console.ReadLine());

                PessoaRep prep = new PessoaRep();
                prep.Alterar(p);

                Console.WriteLine("\nPessoa atualizada com sucesso! \n");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }


    }
}
