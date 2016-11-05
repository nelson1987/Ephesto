using System;

namespace Ephesto.Domain.Entities
{
    public class Produto
    {
        public Produto(int id, string descricao, DateTime criacao, Cliente cliente)
        {
            Id = id;
            Descricao = descricao;
            Criacao = criacao;
            Cliente = cliente;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Criacao { get; set; }
        public Cliente Cliente { get; set; }
    }
}