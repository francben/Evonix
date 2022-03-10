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
    public class EjerciciosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EjerciciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Ejercicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ejercicio>>> GetEjercicios()
        {
            return await _context.Ejercicios.ToListAsync();
        }

        // GET: api/Ejercicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ejercicio>> GetEjercicio(int id)
        {
            var ejercicio = await _context.Ejercicios.FindAsync(id);

            if (ejercicio == null)
            {
                return NotFound();
            }

            return ejercicio;
        }

        // PUT: api/Ejercicios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEjercicio(int id, Ejercicio ejercicio)
        {
            if (id != ejercicio.IdEjercicio)
            {
                return BadRequest();
            }

            var ejequi = new EquipamientoEjercicio();
            var ejemus = new MusculoEjercicio();
            var jej = ejercicio.EquipamientoEjercicios;
            var eje = ejercicio.MusculoEjercicios;
            foreach (var item in jej)
            {
                ejequi = item;
                _context.Add(ejequi);
            }
            foreach (var item in eje)
            {
                ejemus = item;
                _context.Add(ejemus);
            }
            if (EquipamientoEjercicioExists(ejequi.IdEquipamientoEjercicio)){

                _context.Entry(ejequi).State = EntityState.Modified;
            }
            if (MusculoEjerciciosExists(ejemus.IdMusculoEjercicios))
            {
                _context.Entry(ejemus).State = EntityState.Modified;
            }
            _context.Entry(ejercicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EjercicioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();
            return CreatedAtAction("GetEjercicio", new { id = ejercicio.IdEjercicio }, ejercicio);
        }

        // POST: api/Ejercicios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ejercicio>> PostEjercicio(Ejercicio ejercicio)
        {
            _context.Ejercicios.Add(ejercicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEjercicio", new { id = ejercicio.IdEjercicio }, ejercicio);
        }

        // DELETE: api/Ejercicios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEjercicio(int id)
        {
            var ejercicio = await _context.Ejercicios.FindAsync(id);
            if (ejercicio == null)
            {
                return NotFound();
            }

            _context.Ejercicios.Remove(ejercicio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EjercicioExists(int id)
        {
            return _context.Ejercicios.Any(e => e.IdEjercicio == id);
        }
        private bool EquipamientoEjercicioExists(int id)
        {
            return _context.EquipamientoEjercicios.Any(e => e.IdEquipamientoEjercicio == id);
        }        
        private bool MusculoEjerciciosExists(int id)
        {
            return _context.MusculoEjercicios.Any(e => e.IdMusculoEjercicios == id);
        }
    }
}
