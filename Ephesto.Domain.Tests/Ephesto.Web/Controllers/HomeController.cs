using System.Linq.Expressions;
using System.Web.Mvc;
using Ephesto.Domain.Interfaces.Repositories;
using System;
using Elmah;

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
            try
            {
                if (DateTime.Today.Day == 5)
                    throw new Exception("Teste de Erros Elmah in HomeController linha 29");

            }
            catch (Exception ex)
            {
                ErrorSignal.FromCurrentContext().Raise(ex);
            }
            finally
            {
                ViewBag.Message = "Página Inicial do Projeto";
            }
            return View();
        }
    }
}