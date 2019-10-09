using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03._4.Entidades;
using Aula03._4.Controles;

namespace Aula03._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Thiago", "thiago@gmail.com");
            Cliente c2 = new Cliente(2, "Thais", "thais@gmail.com");
            Cliente c3 = new Cliente(3, "Maria", "maria@gmail.com");

            List<Cliente> lista_clientes = new List<Cliente>();  

            lista_clientes.Add(c1);
            lista_clientes.Add(c2);
            lista_clientes.Add(c3);

            try
            {
                ControleCliente cc = new ControleCliente();

                foreach(Cliente c in lista_clientes)
                {
                    cc.ExportarTXT(c);
                    cc.ExportarCSV(c);
                    cc.ExportarXML(c);
                }
                

                Console.WriteLine(".....");
                Console.WriteLine("Arquivo gerado com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadKey();

        }
    }
}
