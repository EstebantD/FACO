﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Presentacion
{
    public class ConfigConnection
    {
        //cadena de conexion para la base de datos, debe tener el mismo nombre que se le asigna al archivo "App.config"//
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
    }
}
