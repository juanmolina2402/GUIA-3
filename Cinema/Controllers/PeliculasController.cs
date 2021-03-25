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
                Id = 2,
                Nombre = "Shrek",
                Genero = "Fantasía",
                AnioDeLanzamiento = "2001",
                Clasificacion = "Todas las edades"
            };
            return View(pelicula);
            //return Content("Hola Mundo!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { pag = 1, OrdenadoPor = "nombre" });
        }

        //public ActionResult Editar(int id)
        //{
        //    return Content("Id: " + id);
        //}

        ////Get Peliculas
        //public ActionResult Index(int? pagIndex, String ordenadoPor)
        //{
        //    if (!pagIndex.HasValue)
        //        pagIndex = 1;
        //    if (String.IsNullOrWhiteSpace(ordenadoPor))
        //        ordenadoPor = "Nombre";

        //    return Content(String.Format("Indice de Página={0}&Ordenado por ={1}", pagIndex, ordenadoPor));
        //}

        ////GET /Peliculas/PorFechaLanzamiento/year/mes
        //public ActionResult PorFechaLanzamiento(int year, int mes)
        //{
        //    return Content(year + "/" + mes);
        //}



        ///////////////////////////EJERCICIO GUIA 3 //////////////////////////////////////////////////////////////////////////////
        // GET: Peliculas/PorOrden
        public ActionResult PorOrden(Int32 opc=0)
        {
            List<Pelicula> listaPelicula = new List<Pelicula>()
            {
                new Pelicula()
                {
                    Id = 1,
                    Nombre = "Rapidos y furiosos",
                    Genero = "Accion",
                    AnioDeLanzamiento = "2001",
                    Clasificacion = "+11"
                },

                new Pelicula()
                {
                    Id = 2,
                    Nombre = "El rey león",
                    Genero = "Animacion",
                    AnioDeLanzamiento = "2000",
                    Clasificacion = "Todo público"
                },

                new Pelicula()
                {
                    Id = 3,
                    Nombre = "Los Vengadores",
                    Genero = "Ciencia ficción",
                    AnioDeLanzamiento = "2012",
                    Clasificacion = "Todo público"
                },

                new Pelicula()
                {
                    Id = 4,
                    Nombre = "La liga de la justicia",
                    Genero = "Ciencia ficción",
                    AnioDeLanzamiento = "2021",
                    Clasificacion = "Todo público"
                },
            };
            
            if(opc == 0)
            {
                return View(listaPelicula);
            }
            else { 
                List<Pelicula> listaOrdenadaNombre = listaPelicula.OrderBy(pNombre => pNombre.Nombre).ToList();
                return View(listaOrdenadaNombre);
            }

        }

    }
}