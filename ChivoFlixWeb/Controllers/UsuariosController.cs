using ChivoFlixWeb.Models;
using ChivoFlixWeb.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Controllers
{
    
    public class UsuariosController : Controller
    {
        private readonly CHIVOFLIXContext _contexto;

        public UsuariosController(CHIVOFLIXContext context)
        {
            _contexto = context;
        }
        public IActionResult Listado()
        {
            HttpContext.Session.GetString("String");

            List<Usuarios> listUsuarios = GetUsuarios();
            return View(listUsuarios);
        }

        private List<Usuarios> GetUsuarios()
        {
            return (from u in _contexto.Usuarios
                    select new Usuarios
                    {
                        IdUsuarios = u.IdUsuarios,
                        Username = u.Username,
                        Email = u.Email,
                        Password = u.Password,
                        Perfiles = u.Perfiles,
                        Imagen = u.Imagen,
                        IdPlanes = u.IdPlanes,
                        IdRol = u.IdRol,
                        IdPlanesNavigation = u.IdPlanesNavigation,
                        Planes = u.Planes,
                        IdRolNavigation = u.IdRolNavigation
                    }).Where(x => x.IdRol == 2).ToList();
        }

        public IActionResult NuevoUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoUsuario(UsuarioVM model)
        {
            var db = _contexto;
            try
            {
                if (ModelState.IsValid)
                {
                    var oUsuario = new Usuarios
                    {
                        Username = model.Username,
                        Email = model.Email,
                        Password = model.Password,
                        Imagen = model.Imagen,
                        IdRol = 1,
                        IdPlanes = 3,
                        Perfiles = 4,
                    };
                    db.Usuarios.Add(oUsuario);
                    db.SaveChanges();
                    return Redirect("~/Usuarios/Listado/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult EditarUsuario(int id)
        {
            UsuarioVM model = new();
            var oUsuario = _contexto.Usuarios.Find(id);
            model.IdUsuarios = oUsuario.IdUsuarios;
            model.Username = oUsuario.Username;
            model.Email = oUsuario.Email;
            model.Password = oUsuario.Password;
            model.Imagen = oUsuario.Imagen;

            return View(model);
        }

        [HttpPost]
        public IActionResult EditarUsuario(UsuarioVM model)
        {
            var db = _contexto;
            try
            {
                if (ModelState.IsValid)
                {
                    var oUsuario = db.Usuarios.Find(model.IdUsuarios);
                    oUsuario.Username = model.Username;
                    oUsuario.Email = model.Email;
                    oUsuario.Password = model.Password;
                    oUsuario.Imagen = model.Imagen;
                    oUsuario.IdRol = 1;
                    oUsuario.IdPlanes = 3;
                    oUsuario.Perfiles = 4;

                    db.Entry(oUsuario).State = EntityState.Modified;
                    db.SaveChanges();

                    return Redirect("~/Usuarios/Listado");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult EliminarUsuario(int id)
        {
            var db = _contexto;
            using (db)
            {
                var oUsuario = db.Usuarios.Find(id);
                db.Usuarios.Remove(oUsuario);
                db.SaveChanges();
            }
            return Redirect("~/Usuarios/Listado");
        }
        [HttpGet]
        public IActionResult VerUsuario(int id)
        {
            var db = _contexto;
            UsuarioVM model = new();
            using (db)
            {
                var oUsuario = db.Usuarios.Find(id);
                model.IdUsuarios = oUsuario.IdUsuarios;
                model.Username = oUsuario.Username;
                model.Email = oUsuario.Email;
                model.Password = oUsuario.Password;
                model.Imagen = oUsuario.Imagen;
            }
            return View(model);
        }

        public IActionResult Reporte()
        {
            return new ViewAsPdf("Reporte", GetUsuarios())
            {

            };
        }
    }
}
