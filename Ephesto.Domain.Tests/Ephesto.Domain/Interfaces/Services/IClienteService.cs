using Ephesto.Domain.Entities;

namespace Ephesto.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente CriarCliente(Cliente cliente);
    }
}