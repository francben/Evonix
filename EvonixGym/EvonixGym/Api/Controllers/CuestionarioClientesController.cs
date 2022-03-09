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
    public class CuestionarioClientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CuestionarioClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CuestionarioClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuestionarioClientes>>> GetCuestionarioClientes()
        {
            return await _context.CuestionarioClientes.ToListAsync();
        }

        // GET: api/CuestionarioClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CuestionarioClientes>> GetCuestionarioClientes(int id)
        {
            var cuestionarioClientes = await _context.CuestionarioClientes.FindAsync(id);

            if (cuestionarioClientes == null)
            {
                return NotFound();
            }

            return cuestionarioClientes;
        }

        // PUT: api/CuestionarioClientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuestionarioClientes(int id, CuestionarioClientes cuestionarioClientes)
        {
            if (id != cuestionarioClientes.IdCuestionarioClientes)
            {
                return BadRequest();
            }

            _context.Entry(cuestionarioClientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuestionarioClientesExists(id))
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

        // POST: api/CuestionarioClientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CuestionarioClientes>> PostCuestionarioClientes(CuestionarioClientes cuestionarioClientes)
        {
            _context.CuestionarioClientes.Add(cuestionarioClientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuestionarioClientes", new { id = cuestionarioClientes.IdCuestionarioClientes }, cuestionarioClientes);
        }

        // DELETE: api/CuestionarioClientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuestionarioClientes(int id)
        {
            var cuestionarioClientes = await _context.CuestionarioClientes.FindAsync(id);
            if (cuestionarioClientes == null)
            {
                return NotFound();
            }

            _context.CuestionarioClientes.Remove(cuestionarioClientes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CuestionarioClientesExists(int id)
        {
            return _context.CuestionarioClientes.Any(e => e.IdCuestionarioClientes == id);
        }
    }
}
