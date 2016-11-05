using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Web.Mappers;
using Ephesto.Web.ViewModels;

namespace Ephesto.Web.Controllers
{
    public class UsuarioApiController : ApiController
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioApiController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioApiController()
        {
            AutoMapperConfig.RegisterMappings();
        }

        public List<Usuario> Listar()
        {
            return new List<Usuario>
            {
                new Usuario(0, "Usuario 0", "usuario0", new List<Perfil>()),
                new Usuario(1, "Usuario 1", "usuario1", new List<Perfil>()),
                new Usuario(2, "Usuario 2", "usuario2", new List<Perfil>()),
                new Usuario(3, "Usuario 3", "usuario3", new List<Perfil>()),
                new Usuario(4, "Usuario 4", "usuario4", new List<Perfil>()),
                new Usuario(5, "Usuario 5", "usuario5", new List<Perfil>()),
                new Usuario(6, "Usuario 6", "usuario6", new List<Perfil>()),
                new Usuario(7, "Usuario 7", "usuario7", new List<Perfil>()),
                new Usuario(8, "Usuario 8", "usuario8", new List<Perfil>()),
                new Usuario(9, "Usuario 9", "usuario9", new List<Perfil>()),
                new Usuario(10, "Usuario 10", "usuario10", new List<Perfil>()),
                new Usuario(11, "Usuario 11", "usuario11", new List<Perfil>()),
                new Usuario(12, "Usuario 12", "usuario12", new List<Perfil>()),
                new Usuario(13, "Usuario 13", "usuario13", new List<Perfil>()),
                new Usuario(14, "Usuario 14", "usuario14", new List<Perfil>()),
                new Usuario(15, "Usuario 15", "usuario15", new List<Perfil>()),
                new Usuario(16, "Usuario 16", "usuario16", new List<Perfil>()),
                new Usuario(17, "Usuario 17", "usuario17", new List<Perfil>()),
                new Usuario(18, "Usuario 18", "usuario18", new List<Perfil>()),
                new Usuario(19, "Usuario 19", "usuario19", new List<Perfil>()),
                new Usuario(20, "Usuario 20", "usuario20", new List<Perfil>()),
                new Usuario(21, "Usuario 21", "usuario21", new List<Perfil>()),
                new Usuario(22, "Usuario 22", "usuario22", new List<Perfil>()),
                new Usuario(23, "Usuario 23", "usuario23", new List<Perfil>()),
                new Usuario(24, "Usuario 24", "usuario24", new List<Perfil>()),
                new Usuario(25, "Usuario 25", "usuario25", new List<Perfil>()),
                new Usuario(26, "Usuario 26", "usuario26", new List<Perfil>()),
                new Usuario(27, "Usuario 27", "usuario27", new List<Perfil>()),
                new Usuario(28, "Usuario 28", "usuario28", new List<Perfil>()),
                new Usuario(29, "Usuario 29", "usuario29", new List<Perfil>()),
                new Usuario(30, "Usuario 30", "usuario30", new List<Perfil>()),
                new Usuario(31, "Usuario 31", "usuario31", new List<Perfil>()),
                new Usuario(32, "Usuario 32", "usuario32", new List<Perfil>()),
                new Usuario(33, "Usuario 33", "usuario33", new List<Perfil>()),
                new Usuario(34, "Usuario 34", "usuario34", new List<Perfil>()),
                new Usuario(35, "Usuario 35", "usuario35", new List<Perfil>()),
                new Usuario(36, "Usuario 36", "usuario36", new List<Perfil>()),
                new Usuario(37, "Usuario 37", "usuario37", new List<Perfil>()),
                new Usuario(38, "Usuario 38", "usuario38", new List<Perfil>()),
                new Usuario(39, "Usuario 39", "usuario39", new List<Perfil>()),
                new Usuario(40, "Usuario 40", "usuario40", new List<Perfil>()),
                new Usuario(41, "Usuario 41", "usuario41", new List<Perfil>()),
                new Usuario(42, "Usuario 42", "usuario42", new List<Perfil>()),
                new Usuario(43, "Usuario 43", "usuario43", new List<Perfil>()),
                new Usuario(44, "Usuario 44", "usuario44", new List<Perfil>()),
                new Usuario(45, "Usuario 45", "usuario45", new List<Perfil>()),
                new Usuario(46, "Usuario 46", "usuario46", new List<Perfil>()),
                new Usuario(47, "Usuario 47", "usuario47", new List<Perfil>()),
                new Usuario(48, "Usuario 48", "usuario48", new List<Perfil>()),
                new Usuario(49, "Usuario 49", "usuario49", new List<Perfil>()),
                new Usuario(50, "Usuario 50", "usuario50", new List<Perfil>()),
                new Usuario(51, "Usuario 51", "usuario51", new List<Perfil>()),
                new Usuario(52, "Usuario 52", "usuario52", new List<Perfil>()),
                new Usuario(53, "Usuario 53", "usuario53", new List<Perfil>()),
                new Usuario(54, "Usuario 54", "usuario54", new List<Perfil>()),
                new Usuario(55, "Usuario 55", "usuario55", new List<Perfil>()),
                new Usuario(56, "Usuario 56", "usuario56", new List<Perfil>())
            };
        }

        [Route("Usuarios")]
        [HttpGet]
        public List<UsuarioApiModel> Get()
        {
            return Mapper.Map<List<UsuarioApiModel>>(Listar()
                .OrderBy(x => x.Id)
                .Take(10)
                .ToList());
        }

        [Route("Usuarios/{total}/{ordem}")]
        [HttpGet]
        public List<UsuarioApiModel> Get(int total, string ordem)
        {
            Func<Usuario, object> property =
                t => typeof (Usuario).GetProperty(ordem).GetMethod.Invoke(t, new object[] {});
            return Mapper.Map<List<UsuarioApiModel>>(Listar()
                .OrderBy(property)
                .Take(total)
                .ToList());
        }
    }
}