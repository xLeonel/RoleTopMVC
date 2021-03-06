using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public uint TipoUsuario { get; set; }
        public string URLFotoPerfil { get; set; }
        public uint StatusCliente { get; set; }
        public ulong Id { get; set; }

        public Cliente()
        {

        }

        public Cliente(string Nome, string Senha, string Email, string Celular, string Cpf, DateTime DataNascimento)
        {
            this.Id = 0;
            this.Nome = Nome;
            this.Senha = Senha;
            this.Email = Email;
            this.Celular = Celular;
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
            this.StatusCliente = (uint)StatusClientes.SEMBAN;
        }
    }
}