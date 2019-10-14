using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Contratos;
using Proj01.Controles;
using Proj01.Entidades;
using Proj01.Entidades.Tipos;

namespace Proj01
{
    class Program
    {
        static void Main(string[] args)
        {
            IControleCliente ct = null;

            Console.WriteLine("\n Escolha: 1 - LINQ ou 2 - LAMBDA \n");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao) { 
                case 1:
                ct = new ControleClienteLinq();
                break;

                case 2:
                ct = new ControleClienteLambda();
                break;
            }

            switch (opcao)
            {
                case 1:
                    Cliente c1 = new Cliente(1, "Rosa", Sexo.Feminino, EstadoCivil.Casaso);
                    Cliente c2 = new Cliente(2, "Joaquim", Sexo.Masculino, EstadoCivil.Casaso);
                    Cliente c3 = new Cliente(3, "Aline", Sexo.Feminino, EstadoCivil.Casaso);
                    Cliente c4 = new Cliente(4, "Thiago", Sexo.Masculino, EstadoCivil.Casaso);
                    Cliente c5 = new Cliente(4, "Thais", Sexo.Feminino, EstadoCivil.Casaso);

                    ct.Inserir(c1);
                    ct.Inserir(c2);
                    ct.Inserir(c3);
                    ct.Inserir(c4);
                    ct.Inserir(c5);
                    break;

                case 2:
                    Cliente c6 = new Cliente(1, "Maria", Sexo.Feminino, EstadoCivil.Casaso);
                    Cliente c7 = new Cliente(2, "Ivan", Sexo.Masculino, EstadoCivil.Casaso);
                    Cliente c8 = new Cliente(3, "Thais", Sexo.Feminino, EstadoCivil.Casaso);
                    Cliente c9 = new Cliente(4, "Thiago", Sexo.Masculino, EstadoCivil.Casaso);
                    

                    ct.Inserir(c6);
                    ct.Inserir(c7);
                    ct.Inserir(c8);
                    ct.Inserir(c9);
                 
                    break;
            }

            Console.WriteLine("\n Exibindo todos os clientes: \n");
            foreach (Cliente c in ct.ConsultarTodos())
            {
                Console.WriteLine("Cliente: " + c.ToString());
            }

            Console.WriteLine("\n Exibindo todos os clientes do sexo masculino: \n");
            foreach (Cliente c in ct.ConsultarPorSexo(Sexo.Masculino))
            {
                Console.WriteLine("Cliente do sexo masculino: " + c.ToString());
            }

            Console.WriteLine("\n Exibindo todos os clientes do sexo feminino: \n");
            foreach (Cliente c in ct.ConsultarPorSexo(Sexo.Feminino))
            {
                Console.WriteLine("Cliente do sexo feminino: " + c.ToString());
            }


            Console.ReadKey();
        }
    }
}
