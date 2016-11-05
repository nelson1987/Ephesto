using System;
using System.Collections.Generic;

namespace Ephesto.Domain.Entities
{
    public class Usuario
    {
        public Usuario(int id, string nome, string login, List<Perfil> perfis)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Perfis = perfis;
            Validar();
        }

        public Usuario(string nome, string login)
            : this(0, nome, login, new List<Perfil>())
        {
        }

        public Usuario(string nome, string login, string perfil)
            : this(0, nome, login, new List<Perfil> {new Perfil(perfil)})
        {
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Login { get; private set; }
        public List<Perfil> Perfis { get; private set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome é obrigatório para o Usuarios.");

            if (string.IsNullOrEmpty(Login))
                throw new Exception("Login é obrigatório para o Usuarios.");
        }
    }
}