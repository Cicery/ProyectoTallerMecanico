﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Datos
{
   public static class DAOConexion
    {
        private static string _cadenaConexion;

        public static string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion =  ConfigurationManager.
                        ConnectionStrings["TallerMecanico.Properties.Settings.Conexion"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
        }
    }
}
