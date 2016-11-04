using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ephesto.Domain.Entities;

namespace Ephesto.Domain.Tests.Entities
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void CriarCliente()
        {
            Cliente cliente = new Cliente("Globo.com","globo_esporte");
            Assert.AreEqual(cliente.Login, "globo_esporte");
        }
    }
}
