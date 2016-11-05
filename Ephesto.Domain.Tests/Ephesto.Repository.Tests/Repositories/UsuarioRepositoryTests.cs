using System.Collections.Generic;
using System.Data;
using Ephesto.Domain.Entities;
using Ephesto.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Ephesto.Repository.Tests.Repositories
{
    [TestClass]
    public class UsuarioRepositoryTests
    {
        private Mock<IDbConnection> _mock;
        private Mock<IDbTransaction> _transaction;
        private UsuarioRepository _target;

        [TestMethod]
        public void BuscarClientePorId()
        {
            //Arrange
            _mock = new Mock<IDbConnection>();
            _transaction = new Mock<IDbTransaction>();
            _target = new UsuarioRepository(_mock.Object);

            //Act
            var cliente = new Usuario("General Motors", "general_motors");
            _mock.Setup(x => x.BeginTransaction());
            _mock.Setup()
                .Returns(cliente);

            //Assert
            var esperado = _target.IncluirUsuario(cliente);
            var atual = new Usuario(1, "General Motors", "general_motors", new List<Perfil>());
            Assert.AreEqual(esperado.Login, atual.Login);
        }
    }
}