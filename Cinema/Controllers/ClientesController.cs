using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes/Registros
        public ActionResult Registros()
        {
            var cliente = new Clientes()
            {
                Id = 1,
                Nombre = "Juan Carlos Molina Chamel",
                Edad = 25,
                NumeroDeTelefono = "7654-3210",
                DUI = "05678901-2",
                Direccion = "Sonsonate, Sonsonate"
            };
            return View(cliente);
        }
    }
}