using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Entidades;
using Proj01.Entidades.Tipos;

namespace Proj01.Contratos
{
    public interface IControleCliente
    {
        //método abstrato..
        void Inserir(Cliente c);
        //método abstrato..
        void Atualizar(Cliente c);
        //método abstrato..
        void Excluir(int idCliente);
        //método abstrato..
        List<Cliente> ConsultarTodos();
        //método abstrato..
        Cliente ConsultarPorId(int idCliente);
        //método abstrato..
        List<Cliente> ConsultarPorNome(string nome);
        //método abstrato..
        List<Cliente> ConsultarPorSexo(Sexo sexo);
        //método abstrato..
        List<Cliente> ConsultarPorEstadoCivil(EstadoCivil estadoCivil);
    }
}
