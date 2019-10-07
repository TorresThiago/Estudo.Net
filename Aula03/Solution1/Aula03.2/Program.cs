using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03._2.Entidade;

namespace Aula03._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(1,"Thiago");
            Pessoa p2 = new Pessoa(2,"Thais");
            Pessoa p3 = new Pessoa(3,"Aline");
            Pessoa p4 = new Pessoa(4,"Joaquim");
            Pessoa p5 = new Pessoa(5,"Rosa");

            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);

            foreach(Pessoa p in lista)
            {
                Console.WriteLine("Pessoa: " + p.ToString());
            }

            Console.WriteLine("\n - Filtrar Pessoas por Nome: \n");
            Console.Write("Informe o nome: ");
            
            string nome = Console.ReadLine();

            List<Pessoa> resultado = lista.Where(p => p.Nome.StartsWith(nome)).OrderBy(p => p.Nome).ToList();

            foreach (Pessoa p in resultado)
            {
                Console.WriteLine("Pessoa: " + p.ToString());
            }

            Console.ReadKey();

        }
    }
}
