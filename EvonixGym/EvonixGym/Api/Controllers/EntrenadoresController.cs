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
    public class EntrenadoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntrenadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Entrenadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrenador>>> GetEntrenadores()
        {
            //return await _context.Entrenadores.ToListAsync();
            return await _context.Entrenadores.Include(e => e.UsuarioEntrenadores).ThenInclude(u => u.Usuario).ToListAsync();
        }

        // GET: api/Entrenadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entrenador>> GetEntrenador(int id)
        {
            var entrenador = await _context.Entrenadores.FindAsync(id);

            if (entrenador == null)
            {
                return NotFound();
            }

            return entrenador;
        }

        // PUT: api/Entrenadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntrenador(int id, Entrenador entrenador)
        {
            if (id != entrenador.IdEntrenador)
            {
                return BadRequest();
            }

            _context.Entry(entrenador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntrenadorExists(id))
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

        // POST: api/Entrenadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entrenador>> PostEntrenador(Entrenador entrenador)
        {
            _context.Entrenadores.Add(entrenador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntrenador", new { id = entrenador.IdEntrenador }, entrenador);
        }

        // DELETE: api/Entrenadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntrenador(int id)
        {
            var entrenador = await _context.Entrenadores.FindAsync(id);
            if (entrenador == null)
            {
                return NotFound();
            }

            _context.Entrenadores.Remove(entrenador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntrenadorExists(int id)
        {
            return _context.Entrenadores.Any(e => e.IdEntrenador == id);
        }
    }
}
