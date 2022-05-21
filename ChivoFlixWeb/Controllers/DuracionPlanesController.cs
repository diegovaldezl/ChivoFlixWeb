using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChivoFlixWeb.Models;

namespace ChivoFlixWeb.Controllers
{
    public class DuracionPlanesController : Controller
    {
        private readonly CHIVOFLIXContext _context;

        public DuracionPlanesController(CHIVOFLIXContext context)
        {
            _context = context;
        }

        // GET: DuracionPlanes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DuracionPlanes.ToListAsync());
        }

        // GET: DuracionPlanes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duracionPlanes = await _context.DuracionPlanes
                .FirstOrDefaultAsync(m => m.IdDuracionPlanes == id);
            if (duracionPlanes == null)
            {
                return NotFound();
            }

            return View(duracionPlanes);
        }

        // GET: DuracionPlanes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DuracionPlanes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDuracionPlanes,Nombre")] DuracionPlanes duracionPlanes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duracionPlanes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(duracionPlanes);
        }

        // GET: DuracionPlanes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duracionPlanes = await _context.DuracionPlanes.FindAsync(id);
            if (duracionPlanes == null)
            {
                return NotFound();
            }
            return View(duracionPlanes);
        }

        // POST: DuracionPlanes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDuracionPlanes,Nombre")] DuracionPlanes duracionPlanes)
        {
            if (id != duracionPlanes.IdDuracionPlanes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duracionPlanes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuracionPlanesExists(duracionPlanes.IdDuracionPlanes))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(duracionPlanes);
        }

        // GET: DuracionPlanes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duracionPlanes = await _context.DuracionPlanes
                .FirstOrDefaultAsync(m => m.IdDuracionPlanes == id);
            if (duracionPlanes == null)
            {
                return NotFound();
            }

            return View(duracionPlanes);
        }

        // POST: DuracionPlanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var duracionPlanes = await _context.DuracionPlanes.FindAsync(id);
            _context.DuracionPlanes.Remove(duracionPlanes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuracionPlanesExists(int id)
        {
            return _context.DuracionPlanes.Any(e => e.IdDuracionPlanes == id);
        }
    }
}
