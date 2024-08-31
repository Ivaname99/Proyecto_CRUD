using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    // Definimos los parametros que nos permitirà leer y modificar los datos
    // Los metodos {get; set;} nos permitiran obtener, leer y modificar el valor de las propiedades
    public class Clientes
    {
        public string DUI { get; set; } // Definimos la propiedad para obtener el DUI y así los demás
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
    }
}
