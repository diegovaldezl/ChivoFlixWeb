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
    public class PlanesController : ControllerBase
    {
        private readonly DataContext _context;

        public PlanesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Planes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Planes>>> Getplanes()
        {
            return await _context.planes.ToListAsync();
        }

        // GET: api/Planes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Planes>> GetPlanes(int id)
        {
            var planes = await _context.planes.FindAsync(id);

            if (planes == null)
            {
                return NotFound();
            }

            return planes;
        }

        // PUT: api/Planes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanes(int id, Planes planes)
        {
            if (id != planes.idPlanes)
            {
                return BadRequest();
            }

            _context.Entry(planes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanesExists(id))
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

        // POST: api/Planes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Planes>> PostPlanes(Planes planes)
        {
            _context.planes.Add(planes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanes", new { id = planes.idPlanes }, planes);
        }

        // DELETE: api/Planes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanes(int id)
        {
            var planes = await _context.planes.FindAsync(id);
            if (planes == null)
            {
                return NotFound();
            }

            _context.planes.Remove(planes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanesExists(int id)
        {
            return _context.planes.Any(e => e.idPlanes == id);
        }
    }
}
