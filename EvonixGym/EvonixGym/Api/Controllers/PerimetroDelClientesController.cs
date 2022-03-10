using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvonixGym.Data;
using EvonixGym.Modelos;

namespace EvonixGym.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerimetroDelClientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PerimetroDelClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PerimetroDelClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerimetroDelCliente>>> GetperimetroDelClientes()
        {
            return await _context.perimetroDelClientes.ToListAsync();
        }

        // GET: api/PerimetroDelClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerimetroDelCliente>> GetPerimetroDelCliente(int id)
        {
            var perimetroDelCliente = await _context.perimetroDelClientes.FindAsync(id);

            if (perimetroDelCliente == null)
            {
                return NotFound();
            }

            return perimetroDelCliente;
        }

        // PUT: api/PerimetroDelClientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerimetroDelCliente(int id, PerimetroDelCliente perimetroDelCliente)
        {
            if (id != perimetroDelCliente.IdPerimetroCliente)
            {
                return BadRequest();
            }

            _context.Entry(perimetroDelCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerimetroDelClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PerimetroDelClientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PerimetroDelCliente>> PostPerimetroDelCliente(PerimetroDelCliente perimetroDelCliente)
        {
            _context.perimetroDelClientes.Add(perimetroDelCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerimetroDelCliente", new { id = perimetroDelCliente.IdPerimetroCliente }, perimetroDelCliente);
        }

        // DELETE: api/PerimetroDelClientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerimetroDelCliente(int id)
        {
            var perimetroDelCliente = await _context.perimetroDelClientes.FindAsync(id);
            if (perimetroDelCliente == null)
            {
                return NotFound();
            }

            _context.perimetroDelClientes.Remove(perimetroDelCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerimetroDelClienteExists(int id)
        {
            return _context.perimetroDelClientes.Any(e => e.IdPerimetroCliente == id);
        }
    }
}
