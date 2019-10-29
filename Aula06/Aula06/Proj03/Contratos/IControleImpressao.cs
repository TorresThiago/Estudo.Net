using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj03.Contratos
{
    public interface IControleImpressao<T>
    {
        void ImprimirDados(T obj);
    }
}
