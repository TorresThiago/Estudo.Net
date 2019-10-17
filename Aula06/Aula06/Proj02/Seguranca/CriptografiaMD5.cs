using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proj02.Seguranca
{
    public class CriptografiaMD5 : CriptografiaAbstract
    {
        public override string Criptografar(string valor)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] valorBytes = Encoding.UTF8.GetBytes(valor);

            byte[] hash = md5.ComputeHash(valorBytes);

            string resultado = string.Empty;

            foreach(byte b in hash)
            {
                resultado += b.ToString("X");
            }

            return resultado;
        }
    }
}
