using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj02.Entidades
{
    public class Usuario
    {
        //propriedades..
        public Guid IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        //construtor default..
        public Usuario()
        {
            //vazio..
        }
        //sobrecarga de construtores (entrada de argumentos)
        public Usuario(Guid idUsuario, string login, string senha)
        {
            IdUsuario = idUsuario;
            Login = login;
            Senha = senha;
        }
        //sobrescrita do método ToString()..
        public override string ToString()
        {
            return $"Id: {IdUsuario.ToString()}, Login: {Login}, Senha: {Senha}";
        }
    }
}
