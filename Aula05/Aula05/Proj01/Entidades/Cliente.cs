using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj01.Entidades.Tipos;
using Proj01.Entidades;

namespace Proj01.Entidades
{
    public class Cliente
    {
        //propriedades [prop] + 2x[tab]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        //construtor default [ctor] + 2x[tab]
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

        public Cliente()
        {
            //vazio..
        }
        //sobrecarga de construtores (overloading)
        public Cliente(int idCliente, string nome, Sexo sexo, EstadoCivil estadoCivil)
        {
            IdCliente = idCliente;
            Nome = nome;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }
        //sobrescrita (override) do método ToString()
        public override string ToString()
        {
            return $"Id do Cliente: {IdCliente}, Nome: {Nome}, Seco: {Sexo}, Estado Civil: {EstadoCivil}";
        }
    }
}