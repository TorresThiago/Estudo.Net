using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula03._4.Entidades;

namespace Aula03._4.Contratos
{
    public interface IControleCliente
    {
        void ExportarTXT(Cliente c);
        void ExportarCSV(Cliente c);
        void ExportarXML(Cliente c);
    }
}
