using ChivoFlixWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChivoFlixWeb.Controllers
{
    public class ReporteController : Controller
    {
        private readonly CHIVOFLIXContext contexto;

        public ReporteController(CHIVOFLIXContext context)
        {
            contexto = context;
        }
        public IActionResult Index()
        {
            return new ViewAsPdf(View("~/Views/Usuarios/Listado",contexto))
            {

            };
        }
    }
}
