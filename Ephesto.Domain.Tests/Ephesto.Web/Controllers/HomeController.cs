using System.Web.Mvc;
using Ephesto.Domain.Interfaces.Repositories;

namespace Ephesto.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public HomeController()
        {
        }
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Página Inicial do Projeto";
            return View();
        }
    }
}