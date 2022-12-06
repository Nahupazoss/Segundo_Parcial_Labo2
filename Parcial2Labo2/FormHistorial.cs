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
        AccesoDatosPartida basedatosPartida;
        List<PartidaTerminada> partidas;
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
            basedatosPartida = new AccesoDatosPartida();
            partidas = new List<PartidaTerminada>();
            ActualizarDataGrid();
        }

        public void ActualizarDataGrid()
        {
            if(basedatosPartida != null)
            {
                dtgv_historial.DataSource = null;
                partidas = basedatosPartida.ObtenerListaDato();
                dtgv_historial.DataSource = partidas;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dtgv_historial.CurrentRow is not null)
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea eliminar la partida del historial?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int aux = dtgv_historial.CurrentRow.Index;
                    //datos.EliminarDato(aux);
                }
            }
            else
            {
                MessageBox.Show("No posee ningún pasaje cargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
