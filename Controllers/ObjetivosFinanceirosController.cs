using Microsoft.AspNetCore.Mvc;
using PoupaDev.Entities;
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
            var objetivos = _context.Objetivos;

            return Ok(objetivos);
        }

        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            var objetivos = _context.Objetivos.SingleOrDefault(o => o.Id == id);

            if (objetivos == null)
            {
                return NotFound();
            }
            return Ok(objetivos);
        }

        [HttpPost]
        public IActionResult Post(ObjetivoFinanceiroImputModel model)
        {
            var objetivo = new ObjetivoFinanceiro(model.Titulo, model.Descricao, model.ValorObjetivo);

            _context.Objetivos.Add(objetivo);

            var id = objetivo.Id;
            return CreatedAtAction("GetPorId", new { id = id}, model);
        }

        [HttpPost("{id}/Operecoes")]
        public IActionResult PostOperacao(int id, OperacaoImputModel model)
        {
            var operacao = new Operacao(model.Valor, model.TipoOperacao);

            var objetivos = _context.Objetivos.SingleOrDefault(o => o.Id == id);

            if (objetivos == null)
            {
                return NotFound();
            }

            objetivos.RealizarOperacao(operacao);

            return NoContent();
        }

    }
}
