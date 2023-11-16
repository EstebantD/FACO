using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class ServicioProducto 
    {
        Datos.RepositorioProductos RepositorioProductos;
        public ServicioProducto(string connectionString)
        {
            RepositorioProductos = new Datos.RepositorioProductos(connectionString);
        }
        public void Insertar(Productos productos)
        {
            RepositorioProductos.Insert(productos);
        }
        public void Detalles_Producto(Label nombre_producto,Label precio_producto,PictureBox imagen_producto,Panel celda, Label nombre_celda, Label precio_celda, PictureBox imagen_celda, Label estado_celda)
        {
            celda.Visible = true;
            nombre_celda.Text = nombre_producto.Text;
            precio_celda.Text = precio_producto.Text;
            imagen_celda = imagen_producto;
            estado_celda.Text = "Ocupado";

        }
    }
}
