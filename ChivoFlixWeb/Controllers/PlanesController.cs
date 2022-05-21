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
    public class PlanesController : Controller
    {
        private readonly CHIVOFLIXContext _context;

        public PlanesController(CHIVOFLIXContext context)
        {
            _context = context;
        }

        // GET: Planes
        public async Task<IActionResult> Index()
        {
            var cHIVOFLIXContext = _context.Planes.Include(p => p.IdDuracionPlanesNavigation).Include(p => p.IdUsuariosNavigation);
            return View(await cHIVOFLIXContext.ToListAsync());
        }

        // GET: Planes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planes = await _context.Planes
                .Include(p => p.IdDuracionPlanesNavigation)
                .Include(p => p.IdUsuariosNavigation)
                .FirstOrDefaultAsync(m => m.IdPlanes == id);
            if (planes == null)
            {
                return NotFound();
            }

            return View(planes);
        }

        // GET: Planes/Create
        public IActionResult Create()
        {
            ViewData["IdDuracionPlanes"] = new SelectList(_context.DuracionPlanes, "IdDuracionPlanes", "Nombre");
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email");
            return View();
        }

        // POST: Planes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPlanes,Plann,PrecioPlan,IdDuracionPlanes,IdUsuarios")] Planes planes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDuracionPlanes"] = new SelectList(_context.DuracionPlanes, "IdDuracionPlanes", "Nombre", planes.IdDuracionPlanes);
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email", planes.IdUsuarios);
            return View(planes);
        }

        // GET: Planes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planes = await _context.Planes.FindAsync(id);
            if (planes == null)
            {
                return NotFound();
            }
            ViewData["IdDuracionPlanes"] = new SelectList(_context.DuracionPlanes, "IdDuracionPlanes", "Nombre", planes.IdDuracionPlanes);
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email", planes.IdUsuarios);
            return View(planes);
        }

        // POST: Planes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPlanes,Plann,PrecioPlan,IdDuracionPlanes,IdUsuarios")] Planes planes)
        {
            if (id != planes.IdPlanes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanesExists(planes.IdPlanes))
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
            ViewData["IdDuracionPlanes"] = new SelectList(_context.DuracionPlanes, "IdDuracionPlanes", "Nombre", planes.IdDuracionPlanes);
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email", planes.IdUsuarios);
            return View(planes);
        }

        // GET: Planes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planes = await _context.Planes
                .Include(p => p.IdDuracionPlanesNavigation)
                .Include(p => p.IdUsuariosNavigation)
                .FirstOrDefaultAsync(m => m.IdPlanes == id);
            if (planes == null)
            {
                return NotFound();
            }

            return View(planes);
        }

        // POST: Planes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planes = await _context.Planes.FindAsync(id);
            _context.Planes.Remove(planes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanesExists(int id)
        {
            return _context.Planes.Any(e => e.IdPlanes == id);
        }
    }
}
