﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class Conexion
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        protected SqlConnection conexion;
        //cadena de conexion con la base de datos y objetos de conexion
        public Conexion(string connectionString)
        {
            conexion = new SqlConnection(connectionString);
        }

        //abre la conexion con la base de datos//
        public void Open()
        {
            conexion.Open();
        }
        //Cierra la conexion con la base de datos//
        public void Closed()
        {
            conexion.Close();
        }
    }
}
