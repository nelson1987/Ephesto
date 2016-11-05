using System.Linq;
using Ephesto.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephesto.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        [TestMethod]
        public void CriarUsuarioSemPerfil()
        {
            var cliente = new Usuario("Globo.com", "globo_esporte");
            Assert.AreEqual(cliente.Login, "globo_esporte");
        }

        [TestMethod]
        public void CriarUsuario()
        {
            var cliente = new Usuario("Globo.com", "globo_esporte", "Administrador");
            Assert.AreEqual(cliente.Perfis.FirstOrDefault().Descricao, "Administrador");
        }
    }
}