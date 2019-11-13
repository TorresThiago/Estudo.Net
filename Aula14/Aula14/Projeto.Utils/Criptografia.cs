using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projeto.Utils
{
    public class Criptografia
    {
        public static string EncriptarParaMD5(string valor)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] bytes = Encoding.UTF8.GetBytes(valor);

            byte[] hash = md5.ComputeHash(bytes);

            string resultado = string.Empty;

            foreach(byte b in hash)
            {
                resultado += b.ToString("X2"); //Hezadecimal (X2)
            }

            return resultado;
        }

        public static string EncriptarParaSHA1(string valor)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] bytes = Encoding.UTF8.GetBytes(valor);

            byte[] hash = sha1.ComputeHash(bytes);

            string resultado = string.Empty;

            foreach (byte b in hash)
            {
                resultado += b.ToString("X2"); //Hezadecimal (X2)
            }

            return resultado;
        }
    }
}
