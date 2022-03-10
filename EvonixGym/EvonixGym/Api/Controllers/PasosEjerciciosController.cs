using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvonixGym.Data;
using EvonixGym.Data.Modelos;

namespace EvonixGym.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasosEjerciciosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PasosEjerciciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PasosEjercicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PasosEjercicio>>> GetPasosEjercicios()
        {
            return await _context.PasosEjercicios.ToListAsync();
        }

        // GET: api/PasosEjercicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PasosEjercicio>> GetPasosEjercicio(int id)
        {
            var pasosEjercicio = await _context.PasosEjercicios.FindAsync(id);

            if (pasosEjercicio == null)
            {
                return NotFound();
            }

            return pasosEjercicio;
        }

        // PUT: api/PasosEjercicios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPasosEjercicio(int id, PasosEjercicio pasosEjercicio)
        {
            if (id != pasosEjercicio.IdPasos)
            {
                return BadRequest();
            }

            _context.Entry(pasosEjercicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PasosEjercicioExists(id))
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

        // POST: api/PasosEjercicios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PasosEjercicio>> PostPasosEjercicio(PasosEjercicio pasosEjercicio)
        {
            _context.PasosEjercicios.Add(pasosEjercicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPasosEjercicio", new { id = pasosEjercicio.IdPasos }, pasosEjercicio);
        }

        // DELETE: api/PasosEjercicios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePasosEjercicio(int id)
        {
            var pasosEjercicio = await _context.PasosEjercicios.FindAsync(id);
            if (pasosEjercicio == null)
            {
                return NotFound();
            }

            _context.PasosEjercicios.Remove(pasosEjercicio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PasosEjercicioExists(int id)
        {
            return _context.PasosEjercicios.Any(e => e.IdPasos == id);
        }
    }
}
