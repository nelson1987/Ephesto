using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;

namespace Ephesto.Repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public UsuarioRepository(IDbConnection dbConnection)
        {
            //    get { return new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDbConnection"].ConnectionString); }
            _dbConnection = dbConnection;
        }

        public void Dispose()
        {
            SqlConnection.ClearAllPools();
            GC.SuppressFinalize(this);
        }

        public Usuario BuscarPorId(int id)
        {
            using (
                var cn =
                    new SqlConnection(
                        "Server=e288f40d-7aa3-4c1b-94a1-a6b4015cb9bc.sqlserver.sequelizer.com;Database=dbe288f40d7aa34c1b94a1a6b4015cb9bc;User ID=vduhmftaldullart;Password=oo8P2eUQhtada3EjHyssRWAjNdopbdzFLKmk63jVvhiinRaFLL2bPvczVXaWYDPe;")
                )
            {
                var usuario = cn.Query<Usuario>("SELECT * FROM Usuario").FirstOrDefault();
                return usuario;
            }
        }

        public List<Usuario> BuscarPorPerfil(Perfil perfil)
        {
            throw new NotImplementedException();
        }
    }
}