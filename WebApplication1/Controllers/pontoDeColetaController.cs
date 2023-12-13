using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts.Repository;
using WebApplication1.DTO;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("ponto_de_coleta")]
    public class pontoDeColetaController : ControllerBase
    {
        private readonly IPontoDeColeta _pontoDeColetaRepository;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _pontoDeColetaRepository.Get());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _pontoDeColetaRepository.GetById(id));
        }
        public pontoDeColetaController(IPontoDeColeta pontoDeColetaRepository)
        {
            _pontoDeColetaRepository = pontoDeColetaRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add(PontoDeColetaDTO coleta)
        {
            await _pontoDeColetaRepository.Add(coleta);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _pontoDeColetaRepository.Delete(id);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(PontoDeColetaEntity coleta)
        {
            await _pontoDeColetaRepository.Update(coleta);
            return Ok();
        }
    }
}
