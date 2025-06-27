using Modelo.conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas.Formulario
{
    public partial class frmdoctor : Form
    {
        public frmdoctor()
        {
            InitializeComponent();
        }

        private void MostrarDoctores()
        {
            dgvDatosDoctores.DataSource = null;
            dgvDatosDoctores.DataSource =doctor.CargarDoctores();

        }

        private void frmdoctor_Load(object sender, EventArgs e)
        {
            MostrarDoctores();
        }

        private void gpbDatosDelDoctor_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Creamos el objeto de doctor para mandar la informacion dek formulario por el metodo set
            doctor doc = new doctor();
            doc.Nnombre=txtnombre.Text;
            doc.Apellido=txtapellido.Text;
            doc.Especialidad=txtespecialidad.Text;
            doc.Cargo=txtcargo.Text;
            doc.InsertarDoctores();
            limpiarCampoRegistrado();
            MostrarDoctores();
        }

        private void limpiarCampoRegistrado() {
            MessageBox.Show("Registro Exitoso");
            txtnombre.Clear();
            txtapellido.Clear();
            txtespecialidad.Clear();
            txtcargo.Clear();
        
        }
    }
}
