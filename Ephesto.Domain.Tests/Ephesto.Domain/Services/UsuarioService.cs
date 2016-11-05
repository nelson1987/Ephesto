using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Domain.Interfaces.Services;

namespace Ephesto.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario IncluirUsuario(Usuario usuario)
        {
            var duplicado = _usuarioRepository.BuscarPorId(usuario.Id) != null;

            return usuario;
        }
    }
}