using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj02.Controles;

namespace Proj02
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioControle uc = new UsuarioControle();
            uc.ObterDadosUsuario(); //executando..
            Console.ReadKey(); //pausando..
        }
    }
}
