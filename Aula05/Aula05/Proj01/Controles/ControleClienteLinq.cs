using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Contratos;
using Proj01.Entidades;
using Proj01.Entidades.Tipos;

namespace Proj01.Controles
{
    public class ControleClienteLinq : IControleCliente
    {
        private List<Cliente> listagemClientes;
                

        public ControleClienteLinq()
        {
            listagemClientes = new List<Cliente>();
        }
        public void Atualizar(Cliente c)
        {
            var query = from cli in listagemClientes
                        where cli.IdCliente == c.IdCliente
                        select cli;

            if(query.Count() == 1)
            {
                Cliente reg = query.First();

                reg.Nome = c.Nome;
                reg.Sexo = c.Sexo;
                reg.EstadoCivil = c.EstadoCivil;
            }
        }

        public List<Cliente> ConsultarPorEstadoCivil(EstadoCivil estadoCivil)
        {
            var query = from cli in listagemClientes
                        where cli.EstadoCivil == estadoCivil
                        orderby cli.EstadoCivil ascending
                        select cli;
           
            return query.ToList();

        }

        public Cliente ConsultarPorId(int idCliente)
        {
            var query = from cli in listagemClientes
                        where cli.IdCliente == idCliente
                        select cli;

            return query.FirstOrDefault();
        }

        public List<Cliente> ConsultarPorNome(string nome)
        {
            var query = from cli in listagemClientes
                        where cli.Nome.Contains(nome) 
                        orderby cli.Nome ascending
                        select cli;

            return query.ToList();
        }

        public List<Cliente> ConsultarPorSexo(Sexo sexo)
        {
            var query = from cli in listagemClientes
                        where cli.Sexo == sexo
                        orderby cli.Sexo ascending
                        select cli;

            return query.ToList();
        }

        public List<Cliente> ConsultarTodos()
        {
            var query = from cli in listagemClientes                        
                        orderby cli.Nome ascending
                        select cli;

            return query.ToList();
        }

        public void Excluir(int idCliente)
        {
            var query = from cli in listagemClientes
                        where cli.IdCliente == idCliente
                        select cli;

            if(query.Count() == 1)
            {
                //Cliente c = query.First();
                listagemClientes.Remove(query.First());
            }
        }

        public void Inserir(Cliente c)
        {
            var query = from cli in listagemClientes
                        where cli.IdCliente == c.IdCliente
                        select cli;

            if (query.Count() == 0)
            {
                listagemClientes.Add(c);
            }
        }
    }
}
