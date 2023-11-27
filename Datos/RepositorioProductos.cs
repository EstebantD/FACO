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
    public class RepositorioProductos : Conexion
    {
        public RepositorioProductos(string connectionString) : base(connectionString) { }

        public void Insert(Productos productos)

        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into PRODUCTOS(Documento,Nombre_productos,Precio_Total) values (@Documento,@Nombre_productos,@Precio_Total)";
                Comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = productos.Documento;
                Comando.Parameters.Add("@Nombre_productos", SqlDbType.VarChar).Value = productos.Nombre_Producto;
                Comando.Parameters.Add("@Precio_Total", SqlDbType.Int).Value = productos.Precio_Total;
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }

        }
        public DataTable GetAllTabla()
        {
            Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PRODUCTOS";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
    }
}
