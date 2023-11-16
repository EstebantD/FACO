using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        ServicioProducto servicioProducto = new ServicioProducto(ConfigConnection.ConnectionString);
        Manejo_Formulario mj = new Manejo_Formulario();
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();         
        }
        public Label EnviarNombre()
        {
            return lblNombre;
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            mj.Btn_Siguiente(Pnl_Pagina2,Pnl_Pagina3,Pnl_Pagina4,Btn_Anterior,Btn_Siguiente);         
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            mj.Btn_Anterior(Pnl_Pagina2, Pnl_Pagina3, Pnl_Pagina4, Btn_Anterior, Btn_Siguiente);
        }

        private void Pnl_Pagina4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void ImagenProducto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Comprar2_Click(object sender, EventArgs e)
        {
                    }

        private void button5_Click(object sender, EventArgs e)
        {
            btnCarrito1.Visible = false;
            btnCarrito2.Visible = true;
            Pnl_Pagina1.Visible = true;
            Pnl_Pagina2.Visible = true;
            Pnl_Pagina3.Visible = true;
            Pnl_Pagina4.Visible = true;
            panel2.Visible = true;
        }

        private void PrecioProducto1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrito2_Click(object sender, EventArgs e)
        {
            btnCarrito1.Visible=true;
            btnCarrito2.Visible=false;
            panel2.Visible=false;
        }
        
        private void Btn_Añadir1_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto1,PrecioProducto1,Imagen_producto1);
        }
        
        private void Btn_Añadir2_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto2, PrecioProducto2, Imagen_producto2);
        }

        private void Btn_Añadir3_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto3, PrecioProducto3, Imagen_producto3);

        }

        private void Btn_Añadir4_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto4, PrecioProducto4, Imagen_producto4);

        }

        private void Btn_Añadir5_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto5, PrecioProducto5, Imagen_producto5);

        }

        private void Btn_Añadir6_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto6, Precio_Producto6, Imagen_producto6);

        }

        private void Btn_Añadir7_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto7, Precio_Producto7, Imagen_producto7);
        }

        private void Btn_Añadir8_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto8, Precio_Producto8, Imagen_producto8);
        }
        
        private void Btn_Añadir9_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto9, Precio_producto9, Imagen_producto9);
        }

        private void Btn_Añadir10_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto10, Precio_producto10, Imagen_producto10);
        }

        private void Btn_Añadir11_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto11, Precio_producto11, Imagen_producto11);
        }

        private void Btn_Añadir12_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto12, Precio_producto12, Imagen_producto12);
        }

        private void Btn_Añadir13_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto13, Precio_producto13, Imagen_producto13);
        }

        private void Btn_Añadir14_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto14, Precio_producto14, Imagen_producto14);
        }

        private void Btn_Añadir15_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto15, Precio_producto15, Imagen_producto15);
        }

        private void Btn_Añadir16_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto16, Precio_producto16, Imagen_producto16);
        }

        private void Btn_Añadir17_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto17, Precio_producto17, Imagen_producto17);
        }

        private void Btn_Añadir18_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto18, Precio_producto18, Imagen_producto18);
        }

        private void Btn_Añadir19_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto19, Precio_producto19, Imagen_producto19);
        }

        private void Btn_Añadir20_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto20, Precio_producto20, Imagen_producto20);
        }

        private void Btn_Añadir21_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto21, Precio_producto21, Imagen_producto21);
        }

        private void Btn_Añadir22_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto22, Precio_producto22, Imagen_producto22);
        }

        private void Btn_Añadir23_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto23, Precio_producto23, Imagen_producto23);
        }

        private void Btn_Añadir24_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto24, Precio_producto24, Imagen_producto24);
        }

        private void Btn_Añadir25_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto25, Precio_producto25, Imagen_producto25);
        }

        private void Btn_Añadir26_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto26, Precio_producto26, Imagen_producto26);
        }

        private void Btn_Añadir27_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto27, Precio_producto27, Imagen_producto27);
        }

        private void Btn_Añadir28_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto28, Precio_producto28, Imagen_producto28);
        }

        private void Btn_Añadir29_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto29, Precio_producto29, Imagen_producto29);
        }

        private void Btn_Añadir30_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto30, Precio_producto30, Imagen_producto30);
        }
        public void Celdas_Disponibles(Label nombre_producto, Label precio_producto, PictureBox imagen_producto)
        {
            if (lbl_Estado1.Text == "Disponible")
            {
                servicioProducto.Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda1,N_Producto1,PrecioProducto1,Imagen_producto1,lbl_Estado1);
            }
            else if (lbl_Estado2.Text == "Disponible")
            {
                servicioProducto.Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda2,N_Producto2,PrecioProducto2,ImagenProducto2,lbl_Estado2);
            }
            else if (lbl_Estado3.Text == "Disponible")
            {
                servicioProducto.Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda3, N_Producto3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
            }
            else if (lbl_Estado4.Text == "Disponible")
            {
                servicioProducto.Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda4,N_Producto4,PrecioProducto4, ImagenProducto4,lbl_Estado4);
            }
            else if (lbl_Estado5.Text == "Disponible")
            {
                servicioProducto.Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda5, N_Producto5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
            }
            else
            {
                MessageBox.Show("Carrito Lleno");
            }

        }
    }
}
