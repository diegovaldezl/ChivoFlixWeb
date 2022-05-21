﻿using ChivoFlixWeb.Models;
using ChivoFlixWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly CHIVOFLIXContext _context;

        public PeliculasController(CHIVOFLIXContext context)
        {
            _context = context;
        }
        public IActionResult Listado()
        {
            List<Peliculas> listPeliculas;
            listPeliculas = (from pelicula in _context.Peliculas
                            select new Peliculas
                            {
                                IdPeliculas = pelicula.IdPeliculas,
                                Nombre = pelicula.Nombre,
                                AnioEstreno = pelicula.AnioEstreno,
                                CategoriaEdad = pelicula.CategoriaEdad,
                                Descripcion = pelicula.Descripcion,
                                Calidad = pelicula.Calidad,
                                Director = pelicula.Director,
                                Banner = pelicula.Banner,
                                IdGeneros = pelicula.IdGeneros,
                                Pelicula1 = pelicula.Pelicula1
                            }).ToList();
            return View(listPeliculas);
        }

        public IActionResult NuevaPelicula()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NuevaPelicula(PeliculaVM model)
        {
            var db = _context;
            try
            {
                if (ModelState.IsValid)
                {
                    var oPeliculas = new Peliculas
                    {
                        Nombre = model.nombre,
                        AnioEstreno = model.anioEstreno,
                        CategoriaEdad = model.categoriaEdad,
                        Descripcion = model.descripcion,
                        Calidad = model.calidad,
                        Director = model.director,
                        Banner = model.banner,
                        IdGeneros = model.idGeneros,
                        Pelicula1 = model.Pelicula,
                    };
                    db.Peliculas.Add(oPeliculas);
                    db.SaveChanges();
                    return Redirect("~/Peliculas/Listado/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult EditarPelicula(int id)
        {
            PeliculaVM model = new();
            var peliculas = _context.Peliculas.Find(id);
            model.IdPeliculas = peliculas.IdPeliculas;
            model.nombre = peliculas.Nombre;
            model.descripcion = peliculas.Descripcion;
            model.anioEstreno = peliculas.AnioEstreno;
            model.categoriaEdad = peliculas.CategoriaEdad;
            model.calidad = peliculas.Calidad;
            model.director = peliculas.Director;
            model.banner = peliculas.Banner;
            model.idGeneros = peliculas.IdGeneros;
            model.Pelicula = peliculas.Pelicula1;

            return View(model);
        }

        [HttpPost]
        public IActionResult EditarPelicula(PeliculaVM model)
        {
            var db = _context;
            
                if (ModelState.IsValid)
                {
                    var peliculas = db.Peliculas.Find(model.IdPeliculas);
                    peliculas.Nombre = model.nombre;
                    peliculas.AnioEstreno = model.anioEstreno;
                    peliculas.CategoriaEdad = model.categoriaEdad;
                    peliculas.Descripcion = model.descripcion;
                    peliculas.Calidad = model.calidad;
                    peliculas.Director = model.director;
                    peliculas.Banner = model.banner;
                    peliculas.IdGeneros = model.idGeneros;
                    peliculas.Pelicula1 = model.Pelicula;

                    db.Entry(peliculas).State = EntityState.Modified;
                    db.SaveChanges();

                    return Redirect("~/Peliculas/Listado");
                }
                return View(model);
            
        }

        [HttpGet]
        public IActionResult EliminarPelicula(int id)
        {
            var db = _context;
            using (db)
            {
                var peliculas = db.Peliculas.Find(id);
                db.Peliculas.Remove(peliculas);
                db.SaveChanges();
            }
            return Redirect("~/Peliculas/Listado");
        }
    }
}
