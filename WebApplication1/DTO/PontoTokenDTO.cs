using WebApplication1.Entity;

namespace WebApplication1.DTO
{
    public class PontoTokenDTO
    {
        public string Token { get; set; }
        public PontoDeColetaEntity Coletor { get; set; }
    }
}
