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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrar fr = new FormRegistrar();
            fr.Show();
            this.Hide();
        }
    }
}
