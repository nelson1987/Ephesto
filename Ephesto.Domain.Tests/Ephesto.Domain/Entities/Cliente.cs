using System;

namespace Ephesto.Domain.Entities
{
    public class Cliente
    {
        public Cliente(int id, string nome, string login)
        {
            Id = id;
            Nome = nome;
            Login = login;
        }

        public Cliente(string nome, string login)
            : this(0, nome, login)
        {
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Login { get; private set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome é obrigatório para o cliente.");

            if (string.IsNullOrEmpty(Login))
                throw new Exception("Login é obrigatório para o cliente.");
        }
    }
}