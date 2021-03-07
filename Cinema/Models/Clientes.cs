using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String NumeroDeTelefono { get; set; }
        public String DUI { get; set; }
        public String Direccion { get; set; }
    }
}