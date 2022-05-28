using ChivoFlixWeb.Models;
using ChivoFlixWeb.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly CHIVOFLIXContext _contex;
        public AccountController(CHIVOFLIXContext contex)
        {
            _contex = contex;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(_contex.Usuarios.Where(x=>x.Username == username && x.Password == password && x.IdRol == 1).Any())
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }
            TempData["notification"] = "<script language='javascript'>Swal.fire({icon: 'warning',title: 'Error',text: 'Credenciales incorrectas!',})</script>";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Suscripcion()
        {
            GetViewModel();
            return View();
        }

        [HttpPost]
        public IActionResult Suscripcion(UsuarioVM model)
        {
            var db = _contex;
            try
            {
                if (ModelState.IsValid)
                {
                    var oUsuario = new Usuarios
                    {
                        Username = model.Username,
                        Email = model.Email,
                        Password = model.Password,
                        Imagen = "img/usuario.jpg",
                        IdRol = 2,
                        IdPlanes = model.IdPlanes,
                        Perfiles = 4,
                    };
                    db.Usuarios.Add(oUsuario);
                    db.SaveChanges();
                    TempData["notification"] = "<script language='javascript'>Swal.fire({icon: 'success',title: 'Agregado',text: 'Suscripcion Realizada!',})</script>";
                    return View();
                }
                GetViewModel();
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void GetViewModel()
        {
            var listadoPlanes = (from planes in _contex.Planes
                                 join duracion in _contex.DuracionPlanes
           on planes.IdDuracionPlanes equals duracion.IdDuracionPlanes
                                 select new PlanesDuracionVM
                                 {
                                     IdDuracionPlanes = planes.IdPlanes,
                                     Plann = planes.Plann,
                                     PrecioPlan = planes.PrecioPlan,
                                     Nombre = duracion.Nombre,
                                     IdPlanes = planes.IdPlanes
                                 }).ToList();

            List<SelectListItem> items = listadoPlanes.ConvertAll(planes =>
            {
                return new SelectListItem()
                {
                    Text = planes.Plann + " $" + planes.PrecioPlan + ". Por: " + planes.Nombre,
                    Value = planes.IdPlanes.ToString(),
                    Selected = false,
                };
            });
            ViewBag.items = items;
        }
    }
}
