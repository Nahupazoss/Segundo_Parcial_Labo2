using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseParcial2;

namespace Parcial2Labo2
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu principal?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        public void ActualizarDataGrid()
        {
            dtgv_historial.DataSource = null;
            //dtgv_historial.DataSource = Sistema.JugadorPersona;
        }
    }
}
