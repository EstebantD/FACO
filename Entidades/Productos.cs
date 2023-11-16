using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        Productos() { }
        public string Nombre_Producto { get; set; }
        public int Precio { get; set; }

        public Productos(string nombre_Producto, int precio)
        {
            Nombre_Producto = nombre_Producto;
            Precio = precio;
        }
    }
}
