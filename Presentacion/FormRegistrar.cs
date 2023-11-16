using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrar : Form
    {
        Servicio_Ciente servicio_Ciente = new Servicio_Ciente(ConfigConnection.ConnectionString);
        Login login = new Login();
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            login.Documento = int.Parse(txtDocumento.Text);
            login.Nombre_Completo = txtNombreUsuario.Text;
            login.Fecha_Nacimineto = DateTime.Parse(Dtm_FechaN.Text);
            login.Usuario = txtUsuario.Text;
            login.Contraseña = txtContraseña.Text;
            login.Telefono = TxtTelefono.Text;
            servicio_Ciente.Insert(login);
        }
    }
}
