using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioLogin : Conexion
    {
        public RepositorioLogin(string connectionString) : base(connectionString) { }
        public void Insert(Login login)
       
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into Login(Documento,Nombre_Completo,Fecha_Nacimiento,Usuario,Contraseña,Telefono) values (@Documento,@Nombre_Completo,@Fecha_Nacimiento,@Usuario,@Contraseña,@Telefono)";
                Comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = login.Documento;
                Comando.Parameters.Add("@Nombre_Completo", SqlDbType.VarChar).Value = login.Nombre_Completo;
                Comando.Parameters.Add("@Fecha_Nacimiento", SqlDbType.DateTime).Value = login.Fecha_Nacimineto;
                Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = login.Usuario;
                Comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = login.Contraseña;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = login.Telefono;
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }        

        }
        private Login Mapeador_login(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Login clienteLog = new Login();
            clienteLog.Documento = dataReader.GetString(0);
            clienteLog.Nombre_Completo = dataReader.GetString(1);
            clienteLog.Fecha_Nacimineto = dataReader.GetDateTime(2);
            clienteLog.Usuario = dataReader.GetString(3);
            clienteLog.Contraseña = dataReader.GetString(4);
            clienteLog.Telefono = dataReader.GetString(5);

            return clienteLog;
        }

        public List<Login> GetAll()
        {
            List<Login> log = new List<Login>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM LOGIN";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                log.Add(Mapeador_login(lector));
            }
            Closed();
            return log;
        }
        public DataTable GetAllTabla()
        {
            Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM LOGIN";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
    }
}
