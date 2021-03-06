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

        public IActionResult NuevaCategoria()
        {
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
                        Nombre = model.Nombre
                       
                       
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


        public IActionResult EditarCategoria(int id)
        {
            GenerosVM model = new();
            var oGenero = _context.Generos.Find(id);
            model.IdGeneros = oGenero.IdGeneros;
            model.Nombre = oGenero.Nombre;
            

            return View(model);
        }

        [HttpPost]
        public IActionResult EditarCategoria(GenerosVM model)
        {
            var db = _context;
            try
            {
                if (ModelState.IsValid)
                {
                    var oGenero = db.Generos.Find(model.IdGeneros);
                    oGenero.Nombre = model.Nombre;
                   
                   

                    db.Entry(oGenero).State = EntityState.Modified;
                    db.SaveChanges();

                    return Redirect("~/Categorias/Listado");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult EliminarCategoria(int id)
        {
            var db = _context;
            using (db)
            {
                var genero = db.Generos.Find(id);
                db.Generos.Remove(genero);
                db.SaveChanges();
            }
            return Redirect("~/Categorias/Listado");
        }
    }
}
