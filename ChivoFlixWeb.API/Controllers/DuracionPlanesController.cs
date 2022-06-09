using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChivoFlixApi.Data;
using ChivoFlixApi.Models;

namespace ChivoFlixApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuracionPlanesController : ControllerBase
    {
        private readonly DataContext _context;

        public DuracionPlanesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DuracionPlanes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DuracionPlanes>>> GetduracionPlanes()
        {
            return await _context.duracionPlanes.ToListAsync();
        }

        // GET: api/DuracionPlanes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DuracionPlanes>> GetDuracionPlanes(int id)
        {
            var duracionPlanes = await _context.duracionPlanes.FindAsync(id);

            if (duracionPlanes == null)
            {
                return NotFound();
            }

            return duracionPlanes;
        }

        // PUT: api/DuracionPlanes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDuracionPlanes(int id, DuracionPlanes duracionPlanes)
        {
            if (id != duracionPlanes.idDuracionPlanes)
            {
                return BadRequest();
            }

            _context.Entry(duracionPlanes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DuracionPlanesExists(id))
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

        // POST: api/DuracionPlanes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DuracionPlanes>> PostDuracionPlanes(DuracionPlanes duracionPlanes)
        {
            _context.duracionPlanes.Add(duracionPlanes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDuracionPlanes", new { id = duracionPlanes.idDuracionPlanes }, duracionPlanes);
        }

        // DELETE: api/DuracionPlanes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDuracionPlanes(int id)
        {
            var duracionPlanes = await _context.duracionPlanes.FindAsync(id);
            if (duracionPlanes == null)
            {
                return NotFound();
            }

            _context.duracionPlanes.Remove(duracionPlanes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DuracionPlanesExists(int id)
        {
            return _context.duracionPlanes.Any(e => e.idDuracionPlanes == id);
        }
    }
}
