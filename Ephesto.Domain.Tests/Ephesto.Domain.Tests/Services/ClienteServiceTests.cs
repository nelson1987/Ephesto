using System;
using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Ephesto.Domain.Tests.Services
{
    [TestClass]
    public class ClienteServiceTests
    {
        private ClienteService _target;
        private Mock<IClienteRepository> _mock;

        [TestMethod]
        public void CriarCliente()
        {
            //Arrange
            _mock = new Mock<IClienteRepository>();
            _target = new ClienteService(_mock.Object);

            //Act
            Cliente cliente = new Cliente("General Motors", "general_motors");
            _mock.Setup(x => x.BuscarPorId(It.IsAny<int>()))
                .Returns(cliente);

            //Assert
            Cliente esperado = _target.CriarCliente(cliente);
            Cliente atual = new Cliente(1, "General Motors", "general_motors");
            Assert.AreEqual(esperado.Login, atual.Login);
        }
    }
}
