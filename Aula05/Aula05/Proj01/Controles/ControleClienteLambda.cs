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
    public class ControleClienteLambda : IControleCliente
    {
        private List<Cliente> listagemClientes;
        //construtor..
        public ControleClienteLambda()
        {
            //inicializando o atributo..
            listagemClientes = new List<Cliente>();
        }

        public void Atualizar(Cliente c)
        {
            var query = listagemClientes.Where(cli => cli.IdCliente == c.IdCliente);

            if(query.Count() == 1)
            {
                Cliente registro = query.First();

                registro.Nome = c.Nome;
                registro.Sexo = c.Sexo;
                registro.EstadoCivil = c.EstadoCivil;
            }
        }

        public List<Cliente> ConsultarPorEstadoCivil(EstadoCivil estadoCivil)
        {
            var query = listagemClientes.Where(cli => cli.EstadoCivil == estadoCivil).OrderBy(cli => cli.Nome);

            return query.ToList();
        }

        public Cliente ConsultarPorId(int idCliente)
        {
            var query = listagemClientes.Where(cli => cli.IdCliente == idCliente);

            return query.FirstOrDefault();
        }

        public List<Cliente> ConsultarPorNome(string nome)
        {
            var query = listagemClientes.Where(cli => cli.Nome.Contains(nome));


            return query.ToList();
        }

        public List<Cliente> ConsultarPorSexo(Sexo sexo)
        {
            var query = listagemClientes.Where(cli => cli.Sexo == sexo).OrderBy(cli => cli.Sexo);

            return query.ToList();
        }

        public List<Cliente> ConsultarTodos()
        {
            var query = listagemClientes.OrderBy(cli => cli.Nome);

            return query.ToList();
        }

        public void Excluir(int idCliente)
        {
            var query = listagemClientes.Where(cli => cli.IdCliente == idCliente);

            if (query.Count() == 1)
            {
                Cliente reg = query.First();
                listagemClientes.Remove(reg);
            }
        }

        public void Inserir(Cliente c)
        {
            var query = listagemClientes.Where(cli => cli.IdCliente == c.IdCliente);

            if(query.Count() == 0)
            {
                listagemClientes.Add(c);
            }
        }
    }
}
