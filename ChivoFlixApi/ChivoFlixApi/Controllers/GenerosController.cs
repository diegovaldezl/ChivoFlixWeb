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
    public class GenerosController : ControllerBase
    {
        private readonly DataContext _context;

        public GenerosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Generos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Generos>>> Getgeneros()
        {
            return await _context.generos.ToListAsync();
        }

        // GET: api/Generos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Generos>> GetGeneros(int id)
        {
            var generos = await _context.generos.FindAsync(id);

            if (generos == null)
            {
                return NotFound();
            }

            return generos;
        }

        // PUT: api/Generos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneros(int id, Generos generos)
        {
            if (id != generos.idGeneros)
            {
                return BadRequest();
            }

            _context.Entry(generos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenerosExists(id))
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

        // POST: api/Generos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Generos>> PostGeneros(Generos generos)
        {
            _context.generos.Add(generos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGeneros", new { id = generos.idGeneros }, generos);
        }

        // DELETE: api/Generos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeneros(int id)
        {
            var generos = await _context.generos.FindAsync(id);
            if (generos == null)
            {
                return NotFound();
            }

            _context.generos.Remove(generos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GenerosExists(int id)
        {
            return _context.generos.Any(e => e.idGeneros == id);
        }
    }
}
