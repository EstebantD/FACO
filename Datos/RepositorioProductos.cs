using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
                Comando.CommandText = "Insert into Productos(Nombre_Producto,Precio) values (@Nombre_Producto,@Precio)";
                Comando.Parameters.Add("@Nombre_Producto", SqlDbType.VarChar).Value = productos.Nombre_Producto;
                Comando.Parameters.Add("@Precio", SqlDbType.Int).Value = productos.Precio;
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }

        }
    }
}
