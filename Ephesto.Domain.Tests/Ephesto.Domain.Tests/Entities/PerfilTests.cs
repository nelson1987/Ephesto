using System.Linq;
using Ephesto.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephesto.Domain.Tests.Entities
{
    [TestClass]
    public class PerfilTests
    {
        [TestMethod]
        public void CriarPerfil()
        {
            var perfil = new Perfil("Administrador");
            Assert.AreEqual(perfil.Usuarios.FirstOrDefault(), null);
            Assert.AreEqual(perfil.Descricao, "Administrador");
        }
    }
}