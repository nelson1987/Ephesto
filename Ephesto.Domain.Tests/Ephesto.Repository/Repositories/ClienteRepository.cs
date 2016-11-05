using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Ephesto.Domain.Entities;
using Ephesto.Domain.Interfaces.Repositories;

namespace Ephesto.Repository.Repositories
{
    public class ClienteRepository : IClienteRepository, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public ClienteRepository(IDbConnection dbConnection)
        {
        //    get { return new SqlConnection(ConfigurationManager.ConnectionStrings["MusicStoreEntities"].ConnectionString); }
            _dbConnection = dbConnection;
        }

        public Cliente BuscarPorId(int id)
        {
            using (var cn = _dbConnection)
            {
                var album = cn.Query<Cliente>("SELECT * FROM Album Al").FirstOrDefault();
                return album;
            }
        }

        public void Dispose()
        {
            SqlConnection.ClearAllPools();
            GC.SuppressFinalize(this);
        }
    }
}