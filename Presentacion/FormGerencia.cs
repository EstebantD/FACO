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
        private void Cargar_Tabla()
        {

        }
        private void Cargar_Contadores()
        {

        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            Abrir_PanelesGerencia(Pnl_Clientes,true,Pnl_Inventario,false,Pnl_Finanzas,false);
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            Abrir_PanelesGerencia(Pnl_Clientes, false, Pnl_Inventario, true, Pnl_Finanzas, false);
        }

        private void Btn_Finanzas_Click(object sender, EventArgs e)
        {
            Abrir_PanelesGerencia(Pnl_Clientes, false, Pnl_Inventario, false, Pnl_Finanzas, true);

        }
        private void Abrir_PanelesGerencia(Panel clientes,bool clickc,Panel inventario,bool clicki,Panel finanzas,bool clickf)
        {
            if(clientes.Visible==true && inventario.Visible==false && finanzas.Visible==false)
            {
                if(clicki == true)
                {
                    inventario.Visible = true;
                }
                else if(clickf == true)
                {
                    inventario.Visible = true;
                    inventario.Visible=true;
                }
            }
            else if (clientes.Visible == true && inventario.Visible == true && finanzas.Visible == false)
            {
                if (clickc == true)
                {
                    inventario.Visible = false;
                }
                else if (clickf == true)
                {
                    finanzas.Visible = true;
                }
            }
            else if (clientes.Visible == true && inventario.Visible == true && finanzas.Visible == true)
            {
                if (clickc == true)
                {
                    finanzas.Visible=false;
                    inventario.Visible=false;
                }
                else if (clicki == true)
                {
                    finanzas.Visible = false;
                }
            }
        }
    }
}
