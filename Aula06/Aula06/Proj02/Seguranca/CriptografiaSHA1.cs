using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proj02.Seguranca
{
    class CriptografiaSHA1 : CriptografiaAbstract
    {
        public override string Criptografar(string valor)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] valorBytes = Encoding.UTF8.GetBytes(valor);

            byte[] hash = sha1.ComputeHash(valorBytes);

            string resultado = string.Empty;

            foreach (byte b in hash)
            {
                resultado += b.ToString("X");
            }

            return resultado;
        }
    }
}
