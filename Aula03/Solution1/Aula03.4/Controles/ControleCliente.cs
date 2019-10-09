using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03._4.Entidades;
using Aula03._4.Contratos;
using System.IO;
using System.Xml;

namespace Aula03._4.Controles
{
    public class ControleCliente : IControleCliente
    {
        public void ExportarCSV(Cliente c)
        {
            StreamWriter sw = new StreamWriter("C:\\arquivos\\Clientes.csv", true);

            sw.WriteLine($"{c.IdCliente};{c.Nome};{c.Email}");
            sw.Close();
        }

        public void ExportarTXT(Cliente c)
        {
            StreamWriter sw = new StreamWriter("C:\\arquivos\\Clientes.txt", true);
            sw.WriteLine("IdCliente..: " + c.IdCliente);
            sw.WriteLine("Nome.......: " + c.Nome);
            sw.WriteLine("Email......: " + c.Email);

            sw.Close();
        }

        public void ExportarXML(Cliente c)
        {
            XmlWriter xml = XmlWriter.Create("C:\\arquivos\\Clientes.xml");
            xml.WriteStartDocument();

            xml.WriteStartElement("cliente");

            xml.WriteElementString("IdCliente", c.IdCliente.ToString());
            xml.WriteElementString("Nome", c.Nome);
            xml.WriteElementString("Email", c.Email);

            xml.WriteEndDocument();

            xml.Close();
        }
    }
}
