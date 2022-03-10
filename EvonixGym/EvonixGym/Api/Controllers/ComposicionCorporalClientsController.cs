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
    public class ComposicionCorporalClientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComposicionCorporalClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ComposicionCorporalClients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComposicionCorporalClient>>> GetcomposicionCorporalClients()
        {
            return await _context.composicionCorporalClients.ToListAsync();
        }

        // GET: api/ComposicionCorporalClients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComposicionCorporalClient>> GetComposicionCorporalClient(int id)
        {
            var composicionCorporalClient = await _context.composicionCorporalClients.FindAsync(id);

            if (composicionCorporalClient == null)
            {
                return NotFound();
            }

            return composicionCorporalClient;
        }

        // PUT: api/ComposicionCorporalClients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComposicionCorporalClient(int id, ComposicionCorporalClient composicionCorporalClient)
        {
            if (id != composicionCorporalClient.IdCcCliente)
            {
                return BadRequest();
            }

            _context.Entry(composicionCorporalClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComposicionCorporalClientExists(id))
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

        // POST: api/ComposicionCorporalClients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ComposicionCorporalClient>> PostComposicionCorporalClient(ComposicionCorporalClient composicionCorporalClient)
        {
            _context.composicionCorporalClients.Add(composicionCorporalClient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ComposicionCorporalClientExists(composicionCorporalClient.IdCcCliente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetComposicionCorporalClient", new { id = composicionCorporalClient.IdCcCliente }, composicionCorporalClient);
        }

        // DELETE: api/ComposicionCorporalClients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComposicionCorporalClient(int id)
        {
            var composicionCorporalClient = await _context.composicionCorporalClients.FindAsync(id);
            if (composicionCorporalClient == null)
            {
                return NotFound();
            }

            _context.composicionCorporalClients.Remove(composicionCorporalClient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComposicionCorporalClientExists(int id)
        {
            return _context.composicionCorporalClients.Any(e => e.IdCcCliente == id);
        }
    }
}
