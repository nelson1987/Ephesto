using Ephesto.Domain.Entities;

namespace Ephesto.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Cliente BuscarPorId(int id);
    }
}