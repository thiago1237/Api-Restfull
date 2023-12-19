using WebApplication1.DTO;
using WebApplication1.Entity;

namespace WebApplication1.Contracts.Repository
{
  
    public interface IPontoDeColeta
    {
        Task Add(PontoDeColetaDTO coleta);
        Task Update(PontoDeColetaEntity coleta);
        Task Delete(int id);
        Task <PontoDeColetaEntity> GetById(int id);
        Task <IEnumerable<PontoDeColetaEntity>> Get();

        Task<PontoTokenDTO> LogIn(PontoLoginDTO ponto);

    }
    
}
