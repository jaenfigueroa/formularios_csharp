using MiProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiProyecto.Controllers
{
    public class SueldosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ActionHaberes()
        {
            // Se retorna la vista con un nuevo objeto Haberes.
            return View(new Haberes());
        }

        [HttpPost]
        public ActionResult ActionHaberes(Haberes haberes)
        {
            // ViewBag es un diccionario dinámico que permite pasar datos entre
            // el controlador y la vista.
            ViewBag.Bonificacion = haberes.Bonificacion();
            ViewBag.Remuneracion = haberes.Remuneracion();
            ViewBag.Aportacion = haberes.Aportacion();
            ViewBag.Neto = haberes.Neto();

            // Se retorna la vista con los datos calculados.
            return View(haberes);
        }
    }
}