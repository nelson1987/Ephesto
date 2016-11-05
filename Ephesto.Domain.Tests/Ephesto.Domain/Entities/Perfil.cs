using System;
using System.Collections.Generic;

namespace Ephesto.Domain.Entities
{
    public class Perfil
    {
        public Perfil(int id, string descricao, DateTime criacao, List<Usuario> usuarios)
        {
            Id = id;
            Descricao = descricao;
            Criacao = criacao;
            Usuarios = usuarios;
            Validar();
        }
        public Perfil(string descricao)
            : this(0, descricao, DateTime.Now, new List<Usuario>())
        {
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Criacao { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Descrição é obrigatório para o Perfis.");
        }
    }
}