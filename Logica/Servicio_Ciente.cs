using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Servicio_Ciente
    {
        Datos.RepositorioLogin repositorioLogin;
        public Servicio_Ciente(string connectionString)
        {
            repositorioLogin = new Datos.RepositorioLogin(connectionString);
        }
        public void Insert(Login login)
        {
            repositorioLogin.Insert(login);
        }
        public void IniciarSesion(Form menu,Login login,Label nombre)
        {
            if (Buscar_Cuenta(nombre,login) == true)
            {         
                menu.Show();
                MessageBox.Show("Sesion Iniciada");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto");
            }

        }
        public void Registrarse(Login login)
        {
            try
            {
                repositorioLogin.Insert(login);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Registrar");
            }
        }
        
        public bool Buscar_Cuenta(Label nombre,Login login)
        {
            bool Verificar = false;
            foreach (var item in GetAll())
            {
                if (item.Usuario.Equals(login.Usuario)&&item.Contraseña.Equals(login.Contraseña))
                {
                    nombre.Text = item.Nombre_Completo;
                    Verificar = true;
                }
            }
            return Verificar;
        }

        public List<Login> GetAll()
        {
            return repositorioLogin.GetAll();
        }
    }
}
