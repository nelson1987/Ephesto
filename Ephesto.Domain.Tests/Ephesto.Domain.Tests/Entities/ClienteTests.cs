using Ephesto.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ephesto.Domain.Tests.Entities
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void CriarCliente()
        {
            var cliente = new Cliente("Globo.com", "globo_esporte");
            Assert.AreEqual(cliente.Login, "globo_esporte");
        }
    }
}