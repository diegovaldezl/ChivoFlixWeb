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
    public class UsuariosController : Controller
    {
        public IActionResult Usuarios()
        {
            List<Usuarios> listUsuarios;
            using(CHIVOFLIXContext db = new())
            {
                listUsuarios = (from u in db.Usuarios select new Usuarios
                {
                    IdUsuarios = u.IdUsuarios,
                    Username = u.Username,
                    Email = u.Email,
                    Password = u.Password,
                    Perfiles = u.Perfiles,
                    Imagen = u.Imagen,
                    IdPlanes = u.IdPlanes,
                    IdRol = u.IdRol
                }).ToList();
            }
            return View(listUsuarios);
        }
        
        public IActionResult NuevoUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoUsuario(UsuarioVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using CHIVOFLIXContext db = new();
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
                    return Redirect("~/Usuarios/Usuarios");
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
            using(CHIVOFLIXContext db = new())
            {
                var oUsuario = db.Usuarios.Find(id);
                model.Username = oUsuario.Username;
                model.Email = oUsuario.Email;
                model.Password = oUsuario.Password;
                model.Imagen = oUsuario.Imagen;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult EditarUsuario(UsuarioVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CHIVOFLIXContext db = new()) {
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
                    };

                    return Redirect("~/Usuarios/Usuarios");
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
            using (CHIVOFLIXContext db = new())
            {
                var oUsuario = db.Usuarios.Find(id);
                db.Usuarios.Remove(oUsuario);
                db.SaveChanges();
            }
            return Redirect("~/Usuarios/Usuarios");
        }
    }
}
