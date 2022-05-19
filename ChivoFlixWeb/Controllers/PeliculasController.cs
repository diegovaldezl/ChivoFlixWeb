using ChivoFlixWeb.Models;
using Microsoft.AspNetCore.Mvc;
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
    }
}
