using ChivoFlixWeb.Models;
using ChivoFlixWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly CHIVOFLIXContext _context;
        public CategoriasController(CHIVOFLIXContext context)
        {
            _context = context;
        }
        public IActionResult Listado()
        {
            List<Generos> listGeneros;
            listGeneros = (from g in _context.Generos
                           select new Generos
                           {
                               IdGeneros = g.IdGeneros,
                               Nombre= g.Nombre
                           }).ToList();
            return View(listGeneros);
        }

        public IActionResult NuevaPelicula()
        {
            List<Generos> listadoGeneros = null;

            listadoGeneros = (from g in _context.Generos
                              select new Generos()
                              {
                                  IdGeneros = g.IdGeneros,
                                  Nombre = g.Nombre
                              }).ToList();

            List<SelectListItem> items = listadoGeneros.ConvertAll(g =>
            {
                return new SelectListItem()
                {
                    Text = g.Nombre.ToString(),
                    Value = g.IdGeneros.ToString(),
                    Selected = false,
                };
            });

            ViewBag.items = items;
            return View();
        }
        [HttpPost]
        public IActionResult NuevaCategoria(GenerosVM model)
        {
            var db = _context;
            try
            {
                if (ModelState.IsValid)
                {
                    var oGeneros = new Generos
                    {
                        IdGeneros = model.IdGeneros,
                        Nombre = model.Nombre,
                       
                       
                    };
                    db.Generos.Add(oGeneros);
                    db.SaveChanges();
                    return Redirect("~/Categorias/Listado/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
