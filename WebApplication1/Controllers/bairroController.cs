using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts.Repository;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("bairro")]
    public class BairroController : ControllerBase
    {
        private readonly IBairro _bairroRepository;
        public BairroController(IBairro bairroRepository)
        {
            _bairroRepository = bairroRepository;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _bairroRepository.Get());
        }
    }
}
