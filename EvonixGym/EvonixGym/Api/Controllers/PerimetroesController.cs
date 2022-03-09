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
    public class PerimetroesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PerimetroesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Perimetroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perimetro>>> GetPerimetros()
        {
            return await _context.Perimetros.ToListAsync();
        }

        // GET: api/Perimetroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Perimetro>> GetPerimetro(int id)
        {
            var perimetro = await _context.Perimetros.FindAsync(id);

            if (perimetro == null)
            {
                return NotFound();
            }

            return perimetro;
        }

        // PUT: api/Perimetroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerimetro(int id, Perimetro perimetro)
        {
            if (id != perimetro.IdPerimetro)
            {
                return BadRequest();
            }

            _context.Entry(perimetro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerimetroExists(id))
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

        // POST: api/Perimetroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Perimetro>> PostPerimetro(Perimetro perimetro)
        {
            _context.Perimetros.Add(perimetro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerimetro", new { id = perimetro.IdPerimetro }, perimetro);
        }

        // DELETE: api/Perimetroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerimetro(int id)
        {
            var perimetro = await _context.Perimetros.FindAsync(id);
            if (perimetro == null)
            {
                return NotFound();
            }

            _context.Perimetros.Remove(perimetro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerimetroExists(int id)
        {
            return _context.Perimetros.Any(e => e.IdPerimetro == id);
        }
    }
}
