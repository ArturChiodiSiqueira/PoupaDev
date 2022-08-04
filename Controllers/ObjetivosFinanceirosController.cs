using Microsoft.AspNetCore.Mvc;
using PoupaDev.Models;

namespace PoupaDev.Controllers
{
    [ApiController]
    [Route("api/objetivos-financeiros")]
    public class ObjetivosFinanceirosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(ObjetivoFinanceiroImputModel model)
        {
            return Ok();
        }

        [HttpPost("{id}/Operecoes")]
        public IActionResult PostOperacao(int id, OperacaoImputModel model)
        {
            return NoContent();
        }

    }
}
