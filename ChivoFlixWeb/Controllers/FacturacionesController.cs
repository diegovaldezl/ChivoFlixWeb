using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChivoFlixWeb.Models;
using Rotativa.AspNetCore;
using Microsoft.EntityFrameworkCore.Query;

namespace ChivoFlixWeb.Controllers
{
    public class FacturacionesController : Controller
    {
        private readonly CHIVOFLIXContext _context;

        public FacturacionesController(CHIVOFLIXContext context)
        {
            _context = context;
        }

        // GET: Facturaciones
        public async Task<IActionResult> Index()
        {
            IIncludableQueryable<Facturaciones, Usuarios> cHIVOFLIXContext = GetFacturaciones();
            return View(await cHIVOFLIXContext.ToListAsync());
        }

        private IIncludableQueryable<Facturaciones, Usuarios> GetFacturaciones()
        {
            return _context.Facturaciones.Include(f => f.IdPlanesNavigation).Include(f => f.IdUsuariosNavigation);
        }

        // GET: Facturaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturaciones = await _context.Facturaciones
                .Include(f => f.IdPlanesNavigation)
                .Include(f => f.IdUsuariosNavigation)
                .FirstOrDefaultAsync(m => m.IdFacturaciones == id);
            if (facturaciones == null)
            {
                return NotFound();
            }

            return View(facturaciones);
        }

        // GET: Facturaciones/Create
        public IActionResult Create()
        {
            ViewData["IdPlanes"] = new SelectList(_context.Planes, "IdPlanes", "Plann");
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email");
            return View();
        }

        // POST: Facturaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFacturaciones,IdUsuarios,IdPlanes,Plann,FechaAdquirido,Tipo,Precio,Total")] Facturaciones facturaciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facturaciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPlanes"] = new SelectList(_context.Planes, "IdPlanes", "Plann", facturaciones.IdPlanes);
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email", facturaciones.IdUsuarios);
            return View(facturaciones);
        }

        // GET: Facturaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturaciones = await _context.Facturaciones.FindAsync(id);
            if (facturaciones == null)
            {
                return NotFound();
            }
            ViewData["IdPlanes"] = new SelectList(_context.Planes, "IdPlanes", "Plann", facturaciones.IdPlanes);
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email", facturaciones.IdUsuarios);
            return View(facturaciones);
        }

        // POST: Facturaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFacturaciones,IdUsuarios,IdPlanes,Plann,FechaAdquirido,Tipo,Precio,Total")] Facturaciones facturaciones)
        {
            if (id != facturaciones.IdFacturaciones)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facturaciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturacionesExists(facturaciones.IdFacturaciones))
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
            ViewData["IdPlanes"] = new SelectList(_context.Planes, "IdPlanes", "Plann", facturaciones.IdPlanes);
            ViewData["IdUsuarios"] = new SelectList(_context.Usuarios, "IdUsuarios", "Email", facturaciones.IdUsuarios);
            return View(facturaciones);
        }

        // GET: Facturaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturaciones = await _context.Facturaciones
                .Include(f => f.IdPlanesNavigation)
                .Include(f => f.IdUsuariosNavigation)
                .FirstOrDefaultAsync(m => m.IdFacturaciones == id);
            if (facturaciones == null)
            {
                return NotFound();
            }

            return View(facturaciones);
        }

        // POST: Facturaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facturaciones = await _context.Facturaciones.FindAsync(id);
            _context.Facturaciones.Remove(facturaciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturacionesExists(int id)
        {
            return _context.Facturaciones.Any(e => e.IdFacturaciones == id);
        }

        public IActionResult Reporte()
        {
            return new ViewAsPdf("Reporte", GetFacturaciones().ToList())
            {

            };
        }
    }
}
