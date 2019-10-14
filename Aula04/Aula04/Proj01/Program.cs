using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Controle;

namespace Proj01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n :: Controle de Clientes :: \n");

                PessoaControle pc = new PessoaControle();
                pc.ControleClientes();

                Console.WriteLine("\n :: Deseja continuar? :: \n S para Sim e N para N \n");
                string opcao = Console.ReadLine();

                if(opcao.ToUpper() == "S") pc.ControleClientes(); //else Console.ReadKey();                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            

        }
    }
}
