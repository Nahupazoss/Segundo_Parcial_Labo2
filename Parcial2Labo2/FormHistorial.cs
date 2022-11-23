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
        AccesoDatos datos;
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
            datos = new AccesoDatos();
        }

        public void ActualizarDataGrid()
        {
            dtgv_historial.DataSource = null;
            dtgv_historial.DataSource = Sistema.PartidasEnJuego;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dtgv_historial.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar el pasajero?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int aux = dtgv_historial.CurrentRow.Index;
                    datos.EliminarDato(aux);
                    this.dtgv_historial.DataSource = null;
                    this.dtgv_historial.DataSource = Sistema.ObtenerJugadoresPersona();
                }
            }
            else
            {
                MessageBox.Show("No posee ningún pasaje cargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
