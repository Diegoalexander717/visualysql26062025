using Modelo.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.conexion
{
    public class doctor
    {

        private int idDoctor;
        private string nnombre;
        private string apellido;
        private string especialidad;
        private string cargo;

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Nnombre { get => nnombre; set => nnombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        //metodo para mostrar la informacion 
        public static DataTable CargarDoctores()
        {
            //necesito traer la informacion 

            SqlConnection conexion = conexionDB.Conectar();
            //vamos a crear el query 
            String consultaquery = "select nombre,apellido,especialidad,cargo from Doctores";
            //creamos un lugar donde podamos rellenar la DataTable
            //por medio del metodo fill
            SqlDataAdapter add = new SqlDataAdapter(consultaquery, conexion);   
            DataTable dataVirtual = new DataTable();
            //vamos a llenar al DataAdapter pasandole una tabla virtual 
            add.Fill(dataVirtual);
            return dataVirtual;
        }
    }
}
