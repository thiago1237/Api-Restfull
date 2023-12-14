using WebApplication1.Entity;

namespace WebApplication1.Contracts.Repository
{
    public interface IBairro
    {
        Task<IEnumerable<BairroEntity>> Get();
    }
}
