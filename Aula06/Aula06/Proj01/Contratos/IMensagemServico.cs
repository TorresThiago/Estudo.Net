using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Entidades;

namespace Proj01.Contratos
{
    public interface IMensagemServico
    {
        void EnviarMensagem(Mensagem msg);
    }
}
