using Dapper;
using WebApplication1.Contracts.Repository;
using WebApplication1.DTO;
using WebApplication1.Entity;
using WebApplication1.Infrastructure;

namespace WebApplication1.Repository
{
    public class PontoDeColetaRepository : Connection, IPontoDeColeta
    {
        public async Task<IEnumerable<PontoDeColetaEntity>> Get()
        {
            string sql = "SELECT * FROM PONTO_DE_COLETA";
            return await GetConnection().QueryAsync<PontoDeColetaEntity>(sql);
        }

        public async Task<PontoDeColetaEntity> GetById(int id)
        {
            string sql = "SELECT * FROM PONTO_DE_COLETA WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<PontoDeColetaEntity>(sql, new {id});

        }
        public async Task Add(PontoDeColetaDTO coleta)
        {
            string sql = @"
            INSERT INTO ponto_de_coleta (Name, Address, Number, Residue)
                VALUE (@Name, @Address, @Number, @Residue)
            ";
            await Execute(sql, coleta);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM ponto_de_coleta WHERE Id = @id";
            await Execute(sql, new { id });
        }


        public async Task Update(PontoDeColetaEntity coleta)
        {
            string sql = @"
                UPDATE PONTO_DE_COLETA
                SET NAME =@Name,
                    ADDRESS = @Address,
                    NUMBER = @Number,
                    RESIDUE = @Residue
                WHERE Id =@id                
             ";
            await Execute(sql, coleta);
        }
    }
}
