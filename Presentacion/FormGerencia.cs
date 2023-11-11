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
    public partial class FormGerencia : Form
    {
        public FormGerencia()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
        }
    }
}
