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



        /////////////////////////////////////////EJERCICIO GUIA 3 //////////////////////////////////////////////////////////////////////////////
        // GET: Peliculas/Indice
        public ActionResult Indice()
        {
            return View();
        }
  
        public ActionResult ResultadoBusqueda(Int32 Opc = 0, String Anio="", String Mes="")
        {
            List<Pelicula> listaOrdenada = null;
            List <Pelicula> listaPelicula = new List<Pelicula>()
            {
                new Pelicula()
                {
                    Id = 1,
                    Nombre = "Rapidos y furiosos",
                    Genero = "Acción",
                    AnioDeLanzamiento = "2001",
                    Mes = "01",
                    Clasificacion = "+11"
                },

                new Pelicula()
                {
                    Id = 2,
                    Nombre = "El rey león",
                    Genero = "Animación",
                    AnioDeLanzamiento = "2000",
                    Mes = "02",
                    Clasificacion = "Todo público"
                },

                new Pelicula()
                {
                    Id = 3,
                    Nombre = "Los Vengadores",
                    Genero = "Ciencia ficción",
                    AnioDeLanzamiento = "2012",
                    Mes = "03",
                    Clasificacion = "Todo público"
                },

                new Pelicula()
                {
                    Id = 4,
                    Nombre = "La liga de la justicia",
                    Genero = "Ciencia ficción",
                    AnioDeLanzamiento = "2021",
                    Mes = "04",
                    Clasificacion = "Todo público"
                },
            };
            
            switch (Opc)
            {
                case 1:
                    listaOrdenada = listaPelicula.OrderBy(pNombre => pNombre.Nombre).ToList();
                    break;
                case 2:
                    listaOrdenada = listaPelicula.Where(pFecha => pFecha.AnioDeLanzamiento == Anio && pFecha.Mes == Mes).ToList();
                    break;
                case 3:
                    listaOrdenada = listaPelicula.Where(pGenero => pGenero.Genero == "Acción").ToList();
                    break;
                case 4:
                    listaOrdenada = listaPelicula.Where(pGenero => pGenero.Genero == "Animación").ToList();
                    break;
                case 5:
                    listaOrdenada = listaPelicula.Where(pGenero => pGenero.Genero == "Ciencia ficción").ToList();
                    break;
                default:
                    listaOrdenada = listaPelicula;
                    break;              
            }
            return View(listaOrdenada);
        }
    }
}