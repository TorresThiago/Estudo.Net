using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Entidades;
using Proj01.Contratos;
using System.Net;
using System.Net.Mail;


namespace Proj01.Servicos
{
    public class MensagemServico : IMensagemServico
    {
        public void EnviarMensagem(Mensagem msg)
        {
            string emaiOrigem = "torres.thiago.rj@gmail.com";
            string senhaOrigem = "T0rr&sT0rr&s";

            //Criando a mensagem de e-mail
            MailMessage mail = new MailMessage(emaiOrigem,msg.EmailDestino);
            mail.Subject = msg.Assunto;
            mail.Body = $"{msg.Conteudo}\n\n ID da Mensagem: {msg.IdMensagem.ToString()}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(emaiOrigem, senhaOrigem);
            smtp.Send(mail);




        }
    }
}
