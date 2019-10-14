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

        public void ExcluirPessoa()
        {
            try
            {
                Console.WriteLine("\n :: Exclusão de Aluno :: \n");
                Pessoa p = new Pessoa();

                Console.WriteLine("Digite o Id: \n");
                p.IdPessoa = Int32.Parse(Console.ReadLine());

                PessoaRep prep = new PessoaRep();
                prep.Excluir(p);

                Console.WriteLine("\nPessoa excluída com sucesso! \n");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public void ConsultarPessoas()
        {
            try
            {
                Console.WriteLine("\n :: Consulta de Pessoas :: \n");

                PessoaRep prep = new PessoaRep();

                List<Pessoa> lista = prep.ListarTodos();

                foreach (Pessoa p in lista)
                {
                    Console.WriteLine("Pessoa: " + p.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }            
        }

        public void ConsultarPorId()
        {
            try
            {
                Console.WriteLine("\n :: Consulta de Pessoas por ID :: \n");
                
                PessoaRep prep = new PessoaRep();
                Console.WriteLine("\n :: Informe o ID da Pessoa :: \n");
                int idPessoa = Int32.Parse(Console.ReadLine());

                Pessoa p = prep.PessoaPorId(idPessoa);

                if(p != null)
                {
                    Console.WriteLine("Pessoa: " + p.ToString());
                }
                else
                {
                    Console.WriteLine("Pessoa não encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public void ControleClientes()
        {
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Alterar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Buscar Todos");
            Console.WriteLine("5 - Buscar por ID\n\n");

            int opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarPessoa();
                    break;

                case 2:
                    AtualizarPessoa();
                    break;

                case 3:
                    ExcluirPessoa();
                    break;

                case 4:
                    ConsultarPessoas();
                    break;

                case 5:
                    ConsultarPorId();
                    break;
            }
        }
    }
}
