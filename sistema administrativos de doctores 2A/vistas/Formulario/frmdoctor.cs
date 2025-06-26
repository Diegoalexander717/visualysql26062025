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
    }
}
