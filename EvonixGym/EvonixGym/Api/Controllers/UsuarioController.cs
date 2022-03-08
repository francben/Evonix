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
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUser()
        {
            //return await _context.Users.ToListAsync();

            return await _context.Users
                    .Include(x => x.UsuarioRoles)
                    .ThenInclude(r => r.Rol)
                    .ToListAsync();
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioRol>> GetUsuarioRol(string id)
        {
            var usuarioRol = await _context.UserRoles.FindAsync(id);

            if (usuarioRol == null)
            {
                return NotFound();
            }

            return usuarioRol;
        }

        // PUT: api/Usuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarioRol(string id, UsuarioRol usuarioRol)
        {
            if (id != usuarioRol.UserId)
            {
                return BadRequest();
            }

            _context.Entry(usuarioRol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioRolExists(id))
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

        // POST: api/Usuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuarioRol>> PostUsuarioRol(UsuarioRol usuarioRol)
        {
            _context.UserRoles.Add(usuarioRol);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuarioRolExists(usuarioRol.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsuarioRol", new { id = usuarioRol.UserId }, usuarioRol);
        }

        // DELETE: api/Usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarioRol(string id)
        {
            var usuarioRol = await _context.UserRoles.FindAsync(id);
            if (usuarioRol == null)
            {
                return NotFound();
            }

            _context.UserRoles.Remove(usuarioRol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioRolExists(string id)
        {
            return _context.UserRoles.Any(e => e.UserId == id);
        }
    }
}
