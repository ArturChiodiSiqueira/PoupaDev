using Microsoft.AspNetCore.Mvc;
using PoupaDev.Models;
using PoupaDev.Persistence;

namespace PoupaDev.Controllers
{
    [ApiController]
    [Route("api/objetivos-financeiros")]
    public class ObjetivosFinanceirosController : ControllerBase
    {
        private readonly PoupaDevContext _context;

        public ObjetivosFinanceirosController(PoupaDevContext context)
        {
            _context = context;
        }

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
