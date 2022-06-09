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
    public class FacturacionesController : ControllerBase
    {
        private readonly DataContext _context;

        public FacturacionesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Facturaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facturaciones>>> Getfacturaciones()
        {
            return await _context.facturaciones.ToListAsync();
        }

        // GET: api/Facturaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Facturaciones>> GetFacturaciones(int id)
        {
            var facturaciones = await _context.facturaciones.FindAsync(id);

            if (facturaciones == null)
            {
                return NotFound();
            }

            return facturaciones;
        }

        // PUT: api/Facturaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturaciones(int id, Facturaciones facturaciones)
        {
            if (id != facturaciones.idFacturaciones)
            {
                return BadRequest();
            }

            _context.Entry(facturaciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturacionesExists(id))
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

        // POST: api/Facturaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Facturaciones>> PostFacturaciones(Facturaciones facturaciones)
        {
            _context.facturaciones.Add(facturaciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturaciones", new { id = facturaciones.idFacturaciones }, facturaciones);
        }

        // DELETE: api/Facturaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacturaciones(int id)
        {
            var facturaciones = await _context.facturaciones.FindAsync(id);
            if (facturaciones == null)
            {
                return NotFound();
            }

            _context.facturaciones.Remove(facturaciones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacturacionesExists(int id)
        {
            return _context.facturaciones.Any(e => e.idFacturaciones == id);
        }
    }
}
