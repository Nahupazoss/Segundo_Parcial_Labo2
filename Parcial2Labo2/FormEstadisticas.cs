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
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de las estadisticas?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            lbl_numCantJugadores.Text = Sistema.JugadorPersona.Count.ToString();
            lbl_ganadas.Text = Sistema.JugadorLogueado.PartidasGanadas.ToString();
            lbl_perdidas.Text = Sistema.JugadorLogueado.PartidasPerdidas.ToString();
            lbl_jugadas.Text = (Sistema.JugadorLogueado.PartidasPerdidas + Sistema.JugadorLogueado.PartidasGanadas).ToString();
        }
    }
}
