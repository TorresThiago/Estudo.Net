using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03.Entidades;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] f = new Funcionario[4];

            Funcionario f1 = new Funcionario(1,"Aline", 1000, DateTime.Now);
            Funcionario f2 = new Funcionario(2,"Rosa", 2000, DateTime.Now);
            Funcionario f3 = new Funcionario(3,"Joaquim", 3000, DateTime.Now);
            Funcionario f4 = new Funcionario(4,"Thiago", 4000, DateTime.Now);

            f[0] = f1;
            f[1] = f2;
            f[2] = f3;
            f[3] = f4;

            
            for (int i = 0; i < f.Length; i++)
            {
                Funcionario fu = f[i];

                Console.WriteLine("Funcionário: " + fu.ToString());
            }

            Console.ReadKey();
        }
    }
}
