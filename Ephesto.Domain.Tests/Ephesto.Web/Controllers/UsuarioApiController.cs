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
                new Usuario(1, "Robert Plant", "usuario1", new List<Perfil>()),
                new Usuario(2, "Rob Halford", "usuario2", new List<Perfil>()),
                new Usuario(3, "Steven Tyler", "usuario3", new List<Perfil>()),
                new Usuario(4, "Chris Cornell", "usuario4", new List<Perfil>()),
                new Usuario(5, "Bon Scott", "usuario5", new List<Perfil>()),
                new Usuario(6, "Freddie Mercury", "usuario6", new List<Perfil>()),
                new Usuario(7, "Bruce Dickinson", "usuario7", new List<Perfil>()),
                new Usuario(8, "Ozzy Osbourne", "usuario8", new List<Perfil>()),
                new Usuario(9, "Paul Rodgers", "usuario9", new List<Perfil>()),
                new Usuario(10,"Ronnie James Dio", "usuario10", new List<Perfil>()),
                new Usuario(11,"Axl Rose", "usuario11", new List<Perfil>()),
                new Usuario(12,"Sammy Hagar", "usuario12", new List<Perfil>()),
                new Usuario(13,"Geddy Lee", "usuario13", new List<Perfil>()),
                new Usuario(14,"Geoff Tate", "usuario14", new List<Perfil>()),
                new Usuario(15,"Mick Jagger", "usuario15", new List<Perfil>()),
                new Usuario(16,"Jonathan Davis", "usuario16", new List<Perfil>()),
                new Usuario(17,"Roger Daltrey" , "usuario17", new List<Perfil>()),
                new Usuario(18,"Paul Stanley", "usuario18", new List<Perfil>()),
                new Usuario(19,"David Lee Roth", "usuario19", new List<Perfil>()),
                new Usuario(20,"Kurt Cobain", "usuario20", new List<Perfil>()),
                new Usuario(21,"Maynard James Keenan", "usuario21", new List<Perfil>()),
                new Usuario(22,"Klaus Meine", "usuario22", new List<Perfil>()),
                new Usuario(23,"Eddie Vedder", "usuario23", new List<Perfil>()),
                new Usuario(24,"James Hetfield", "usuario24", new List<Perfil>()),
                new Usuario(25,"Trent Reznor", "usuario25", new List<Perfil>()),
                new Usuario(26,"Serj Tankian", "usuario26", new List<Perfil>()),
                new Usuario(27,"Layne Staley" 	,"usuario27", new List<Perfil>()),
                new Usuario(28,"Steve Perry" 	,"usuario28", new List<Perfil>()),
                new Usuario(29,"Gene Simmons" 	,"usuario29", new List<Perfil>()),
                new Usuario(30,"Joe Elliott" 	,"usuario30", new List<Perfil>()),
                new Usuario(31,"Jon Bon Jovi" 	,"usuario31", new List<Perfil>()),
                new Usuario(32,"Alice Cooper" 	,"usuario32", new List<Perfil>()),
                new Usuario(33,"Vince Neil" 	,"usuario33", new List<Perfil>()),
                new Usuario(34,"Steve Marriott" ,"usuario34", new List<Perfil>()),
                new Usuario(35,"Lajon Witherspoon" 	, "usuario35", new List<Perfil>()),
                new Usuario(36,"Sebastian Bach" 	, "usuario36", new List<Perfil>()),
                new Usuario(37,"Philip Anselmo" 	, "usuario37", new List<Perfil>()),
                new Usuario(38,"Zack De La Rocha" 	, "usuario38", new List<Perfil>()),
                new Usuario(39,"Brian Johnson" 		, "usuario39", new List<Perfil>()),
                new Usuario(40,"Bret Michaels" 		, "usuario40", new List<Perfil>()),
                new Usuario(41,"Udo Dirkschneider" 	, "usuario41", new List<Perfil>()),
                new Usuario(42,"David Draiman" 		, "usuario42", new List<Perfil>()),
                new Usuario(43,"Ian Gillian" 		, "usuario43", new List<Perfil>()),
                new Usuario(44,"Marilyn Manson" 	, "usuario44", new List<Perfil>()),
                new Usuario(45,"Jeff Keith" 		, "usuario45", new List<Perfil>()),
                new Usuario(46,"Chester Bennington" , "usuario46", new List<Perfil>()),
                new Usuario(47,"Sully Erna" 		, "usuario47", new List<Perfil>()),
                new Usuario(48,"Lemmy Kilmister" 	, "usuario48", new List<Perfil>()),
                new Usuario(49,"Aaron Lewis" 		, "usuario49", new List<Perfil>()),
                new Usuario(50,"Brett Scallions" 	, "usuario50", new List<Perfil>()),
                new Usuario(51,"Chino Moreno" 		, "usuario51", new List<Perfil>()),
                new Usuario(52,"Rob Zombie" 		, "usuario52", new List<Perfil>()),
                new Usuario(53,"Anthony Kiedis", "usuario53", new List<Perfil>()),
                new Usuario(54,"David Coverdale", "usuario54", new List<Perfil>()),
                new Usuario(55,"Gary Cherone", "usuario55", new List<Perfil>()),
                new Usuario(56,"Andrew Wood","usuario56", new List<Perfil>()),
                new Usuario(57,"Scott Weiland", "usuario57", new List<Perfil>()),
                new Usuario(58,"Tom Araya", "usuario58", new List<Perfil>())
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
