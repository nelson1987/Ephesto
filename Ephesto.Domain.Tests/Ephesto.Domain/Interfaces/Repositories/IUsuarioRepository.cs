using System.Collections.Generic;
using Ephesto.Domain.Entities;

namespace Ephesto.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario BuscarPorId(int id);
        List<Usuario> BuscarPorPerfil(Perfil perfil);
    }
}