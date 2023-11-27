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
    public class RepositorioFinanzas : Conexion
    {
        public RepositorioFinanzas(string connectionString) : base(connectionString) { }

        public void Insert(Finanzas finanzas)

        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into FINANZAS(Documento,Fecha_de_Compra,Nombre_productos,Precio_Total) values (@Documento,@Fecha_de_Compra,@Nombre_productos,@Precio_Total)";
                Comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = finanzas.Documento;
                Comando.Parameters.Add("@Fecha_de_Compra", SqlDbType.DateTime).Value = finanzas.Fecha_Compra;
                Comando.Parameters.Add("@Nombre_productos", SqlDbType.VarChar).Value = finanzas.Nombre_Producto;
                Comando.Parameters.Add("@Precio_Total", SqlDbType.Int).Value = finanzas.Precio_Total;
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }

        }
        private Finanzas Mapeador_Finanzas(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Finanzas clienteLog = new Finanzas();
            clienteLog.Documento = dataReader.GetString(0);
            clienteLog.Fecha_Compra = dataReader.GetDateTime(1);
            clienteLog.Nombre_Producto = dataReader.GetString(2);
            clienteLog.Precio_Total = dataReader.GetInt32(3);

            return clienteLog;
        }
        public List<Finanzas> GetAll()
        {
            List<Finanzas> finanzas = new List<Finanzas>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM FINANZAS";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                finanzas.Add(Mapeador_Finanzas(lector));
            }
            Closed();
            return finanzas;
        }
        public DataTable GetAllProductos_Cliente(string documento)
        {
            Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Fecha_de_Compra,Nombre_productos,Precio_Total FROM FINANZAS where Documento = '" + documento + "';";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
        public DataTable GetAllTabla()
        {
            Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Fecha_de_Compra,Nombre_productos,Precio_Total FROM FINANZAS";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
    }
}
