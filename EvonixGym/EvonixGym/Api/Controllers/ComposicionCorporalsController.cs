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
    public class ComposicionCorporalsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComposicionCorporalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComposicionCorporals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComposicionCorporal>>> GetcomposicionCorporals()
        {
            return await _context.composicionCorporals.ToListAsync();
        }

        // GET: api/ComposicionCorporals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComposicionCorporal>> GetComposicionCorporal(int id)
        {
            var composicionCorporal = await _context.composicionCorporals.FindAsync(id);

            if (composicionCorporal == null)
            {
                return NotFound();
            }

            return composicionCorporal;
        }

        // PUT: api/ComposicionCorporals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComposicionCorporal(int id, ComposicionCorporal composicionCorporal)
        {
            if (id != composicionCorporal.IdComposicion)
            {
                return BadRequest();
            }

            _context.Entry(composicionCorporal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComposicionCorporalExists(id))
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

        // POST: api/ComposicionCorporals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComposicionCorporal>> PostComposicionCorporal(ComposicionCorporal composicionCorporal)
        {
            _context.composicionCorporals.Add(composicionCorporal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComposicionCorporal", new { id = composicionCorporal.IdComposicion }, composicionCorporal);
        }

        // DELETE: api/ComposicionCorporals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComposicionCorporal(int id)
        {
            var composicionCorporal = await _context.composicionCorporals.FindAsync(id);
            if (composicionCorporal == null)
            {
                return NotFound();
            }

            _context.composicionCorporals.Remove(composicionCorporal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComposicionCorporalExists(int id)
        {
            return _context.composicionCorporals.Any(e => e.IdComposicion == id);
        }
    }
}
