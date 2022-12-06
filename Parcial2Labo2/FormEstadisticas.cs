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
        AccesoDatos baseDatos;
        AccesoDatosPartida datosPartida;
        public FormEstadisticas()
        {
            InitializeComponent();
            baseDatos = new AccesoDatos();
            datosPartida = new AccesoDatosPartida();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de las estadisticas?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            ActualizarEstadisticas();       
        }

        public void ActualizarEstadisticas()
        {
            baseDatos.ModificarDato(Sistema.JugadorLogueado);
            lbl_numCantJugadores.Text = Sistema.JugadorPersona.Count.ToString();
            lbl_ganadas.Text = datosPartida.ObtenerPartidasPorJugador(Sistema.JugadorLogueado.nombre).FindAll(item => item.Ganador == Sistema.JugadorLogueado.nombre).Count.ToString();
            lbl_perdidas.Text = datosPartida.ObtenerPartidasPorJugador(Sistema.JugadorLogueado.nombre).FindAll(item => item.Ganador != Sistema.JugadorLogueado.nombre && item.Ganador != "Empate").Count.ToString();
            lbl_jugadas.Text = Sistema.JugadorLogueado.partidasJugadas.ToString();
        }
    }
}
