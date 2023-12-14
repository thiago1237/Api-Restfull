using Dapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts.Repository;
using WebApplication1.Entity;
using WebApplication1.Infrastructure;

namespace WebApplication1.Repository
{
    public class BairroRepository : Connection, IBairro
    {
        public async Task<IEnumerable<BairroEntity>> Get()
        {
            string sql = "SELECT * FROM BAIRRO ";
            return await GetConnection().QueryAsync<BairroEntity>(sql);
        }

    }
}
