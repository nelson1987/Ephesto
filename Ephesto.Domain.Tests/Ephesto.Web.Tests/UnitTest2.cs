using System;
using System.Web.Mvc;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Ephesto.Web.Tests
{
    [TestClass]
    public class UsuarioApiTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var mockedRepo = new Mock<IUsuarioRepository>();
            // configure
            var controller = new UsuarioApiController();
            // Act
            var pagina = controller.Get();
            // Assert
            Assert.AreEqual(pagina.Count, 10);
        }
    }
}
