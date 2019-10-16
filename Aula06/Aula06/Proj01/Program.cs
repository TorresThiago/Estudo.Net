using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Controles;

namespace Proj01
{
    class Program
    {
        static void Main(string[] args)
        {
            MensagemControle msg = new MensagemControle();
            msg.EnviarMensagem();

            Console.ReadKey();
        }
    }
}
