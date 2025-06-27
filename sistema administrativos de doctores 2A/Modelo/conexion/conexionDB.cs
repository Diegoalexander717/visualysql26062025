using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.entidades
{
    public class conexionDB
    {
        private static string servidor = "LAB03-DS-EQ10\\SQLEXPRESS";
        private static string basededatos = "dbHospital";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data source={servidor}; initial Catalog= {basededatos};Integrated Security =true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;

    
        }



    }
   
}
