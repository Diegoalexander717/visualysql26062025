using Modelo.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.conexion
{
    public class doctor
    {


        private int idDoctor;
        private string nombre;
        private string apellido;
        private string especialidad;
        private string cargo;

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Nnombre { get => nombre; set => nombre = value; }
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

        public bool InsertarDoctores() {
            //siempre hay q hacer una conexion 

            SqlConnection conexion = conexionDB.Conectar();

            string consultaQueryInsertar = " insert into doctores (nombre,apellido,especialidad,cargo) Values (@nombre,@apellido,@especialidad,@cargo) ";
            SqlCommand insertar = new SqlCommand(consultaQueryInsertar, conexion);
            insertar.Parameters.AddWithValue("@nombre", nombre);
            insertar.Parameters.AddWithValue("@apellido", apellido);
            insertar.Parameters.AddWithValue("@especialidad", especialidad);
            insertar.Parameters.AddWithValue("@cargo", cargo);
            //ahora  ya insertamos valores pero toca validar si se afectaron las filas usaremos ExecuteNonQuery
            //Debermos verificar si lo que se inserto afecto filas

            if (insertar.ExecuteNonQuery() > 0 ) {
             return true;
            }

            else
            {
                return false;
            }

        }
    }

}
