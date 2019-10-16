using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Entidades;
using Proj01.Servicos;

namespace Proj01.Controles
{
    public class MensagemControle
    {
        public void EnviarMensagem()
        {
            try
            {
                Console.WriteLine("\n - Envio de E-mail - \n");

                Mensagem m = new Mensagem();
                m.IdMensagem = Guid.NewGuid();


                Console.WriteLine("Digite o e-mail de destino: ");
                m.EmailDestino = Console.ReadLine();

                Console.WriteLine("Digite o Assunto: ");
                m.Assunto = Console.ReadLine();

                Console.WriteLine("Digite o conteúdo: ");
                m.Conteudo = Console.ReadLine();

                MensagemServico msgServ = new MensagemServico();
                msgServ.EnviarMensagem(m);

                Console.WriteLine("E-mail enviado com sucesso.");
                Console.WriteLine(msgServ.ToString()); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message); 
            }
        }
    }
}
