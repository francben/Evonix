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
    public class MusculosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MusculosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Musculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Musculo>>> GetMusculos()
        {
            return await _context.Musculos.ToListAsync();
        }

        // GET: api/Musculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Musculo>> GetMusculo(int id)
        {
            var musculo = await _context.Musculos.FindAsync(id);

            if (musculo == null)
            {
                return NotFound();
            }

            return musculo;
        }

        // PUT: api/Musculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusculo(int id, Musculo musculo)
        {
            if (id != musculo.IdMusculo)
            {
                return BadRequest();
            }

            _context.Entry(musculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusculoExists(id))
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

        // POST: api/Musculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Musculo>> PostMusculo(Musculo musculo)
        {
            _context.Musculos.Add(musculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMusculo", new { id = musculo.IdMusculo }, musculo);
        }

        // DELETE: api/Musculos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusculo(int id)
        {
            var musculo = await _context.Musculos.FindAsync(id);
            if (musculo == null)
            {
                return NotFound();
            }

            _context.Musculos.Remove(musculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusculoExists(int id)
        {
            return _context.Musculos.Any(e => e.IdMusculo == id);
        }
    }
}
