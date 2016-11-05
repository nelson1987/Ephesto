using System;
using System.Web.Mvc;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Ephesto.Web.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidarPaginaHome()
        {
            // Arrange
            var mockedRepo = new Mock<IUsuarioRepository>();
            // configure
            var controller = new HomeController(mockedRepo.Object);
            // Act
            var pagina = controller.Index() as ViewResult;
            // Assert
            Assert.AreEqual("Página Inicial do Projeto", pagina.ViewBag.Message);
        }
    }
}