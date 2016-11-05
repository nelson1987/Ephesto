using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Domain.Interfaces.Services;

namespace Ephesto.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente CriarCliente(Cliente cliente)
        {
            var duplicado = _clienteRepository.BuscarPorId(cliente.Id) != null;

            return cliente;
        }
    }
}