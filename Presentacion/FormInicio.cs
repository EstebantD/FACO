using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
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

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            mj.Btn_Siguiente(Pnl_Pagina2,Pnl_Pagina3,Pnl_Pagina4,Btn_Anterior,Btn_Siguiente);         
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            mj.Btn_Anterior(Pnl_Pagina2, Pnl_Pagina3, Pnl_Pagina4, Btn_Anterior, Btn_Siguiente);
        }
    }
}
