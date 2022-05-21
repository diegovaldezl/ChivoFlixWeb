using ChivoFlixWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Login(string username, string password)
        {
            if(_contex.Usuarios.Where(x=>x.Username == username && x.Password == password && x.IdRol == 1).Any())
            {
                //HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
