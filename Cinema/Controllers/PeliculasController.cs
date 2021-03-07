using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas/Aleatorias
        public ActionResult Aleatorias()
        {
            var pelicula = new Pelicula() {
                Id = 1,
                Nombre = "Shrek",
                Genero = "Fantasía",
                AnioDeLanzamiento = "2001",
                Clasificacion = "Todas las edades"
            };
            return View(pelicula);
        }
    }
}