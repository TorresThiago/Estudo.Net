using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj02.Entidades;
using Proj02.Seguranca;

namespace Proj02.Controles
{
    public class UsuarioControle
    {
        public void ObterDadosUsuario()
        {
            try
            {
                Console.WriteLine("\n - Controle de Usuarios - \n");

                Usuario u = new Usuario();

                u.IdUsuario = Guid.NewGuid();

                Console.WriteLine("Informe o Login do Usuario....");
                u.Login = Console.ReadLine();

                Console.WriteLine("Informe 1(MD5) ou 2(SHA1).....");
                int opcao = Int32.Parse(Console.ReadLine());

                CriptografiaAbstract c = null;

                switch (opcao)
                {
                    case 1:
                        c = new CriptografiaMD5();
                        break;

                    case 2:
                        c = new CriptografiaSHA1();
                        break;
                }

                Console.WriteLine("Informe a senha do usuario:");
                u.Senha = c.Criptografar(Console.ReadLine());

                Console.WriteLine("\nDados do Usuario:");
                Console.WriteLine("ID...." + u.IdUsuario.ToString());
                Console.WriteLine("Login." + u.Login);
                Console.WriteLine("Senha." + u.Senha);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:" + e.Message);
            }
        }
    }
}
