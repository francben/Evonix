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
    public class EquipamientosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EquipamientosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Equipamientos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipamiento>>> GetEquipamientos()
        {
            return await _context.Equipamientos.ToListAsync();
        }

        // GET: api/Equipamientos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipamiento>> GetEquipamiento(int id)
        {
            var equipamiento = await _context.Equipamientos.FindAsync(id);

            if (equipamiento == null)
            {
                return NotFound();
            }

            return equipamiento;
        }

        // PUT: api/Equipamientos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipamiento(int id, Equipamiento equipamiento)
        {
            if (id != equipamiento.IdEquipamiento)
            {
                return BadRequest();
            }

            _context.Entry(equipamiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipamientoExists(id))
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

        // POST: api/Equipamientos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Equipamiento>> PostEquipamiento(Equipamiento equipamiento)
        {
            _context.Equipamientos.Add(equipamiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipamiento", new { id = equipamiento.IdEquipamiento }, equipamiento);
        }

        // DELETE: api/Equipamientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipamiento(int id)
        {
            var equipamiento = await _context.Equipamientos.FindAsync(id);
            if (equipamiento == null)
            {
                return NotFound();
            }

            _context.Equipamientos.Remove(equipamiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EquipamientoExists(int id)
        {
            return _context.Equipamientos.Any(e => e.IdEquipamiento == id);
        }
    }
}
