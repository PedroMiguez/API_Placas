using System.Collections.Generic;
using System.Linq;
using API_Placas.Data;
using API_Placas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Placas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlacaController :ControllerBase
    {
        private PlacaContext _context;
        
        public PlacaController(PlacaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarPlaca([FromBody] Placa placa)
        {
            _context.Placas.Add(placa); 
            return CreatedAtAction(nameof(RecuperaPlacaporID), new { Id = placa.Id }, placa);
        }
        [HttpGet]
        public IActionResult RecuperarPlacas()
        {
            return Ok(_context.Placas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPlacaporID(int id)
        {
            Placa placa = _context.Placas.FirstOrDefault(placa => placa.Id == id);
            if (placa != null)
            {
                return Ok(placa);
            }
            return NotFound();
        }

    }
}
