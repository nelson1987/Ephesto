using System.Collections.Generic;
using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;
using Ephesto.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Ephesto.Domain.Tests.Services
{
    [TestClass]
    public class UsuarioServiceTests
    {
        private Mock<IUsuarioRepository> _mock;
        private UsuarioService _target;

        [TestMethod]
        public void CriarCliente()
        {
            //Arrange
            _mock = new Mock<IUsuarioRepository>();
            _target = new UsuarioService(_mock.Object);

            //Act
            var cliente = new Usuario("General Motors", "general_motors");
            _mock.Setup(x => x.BuscarPorId(It.IsAny<int>()))
                .Returns(cliente);

            //Assert
            var esperado = _target.IncluirUsuario(cliente);
            var atual = new Usuario(1, "General Motors", "general_motors",new List<Perfil>());
            Assert.AreEqual(esperado.Login, atual.Login);
        }
    }
}