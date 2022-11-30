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
    public partial class FormCrearPartida : Form
    {
        JugadorPersona jugador;
        //FormJugadorV2 menuPartidaSimulada;
        public FormCrearPartida(JugadorPersona jugadorPersona)
        {
            InitializeComponent();
            jugador = jugadorPersona;
        }

        private void FormCrearPartida_Load(object sender, EventArgs e)
        {
            this.img_dados2.Image = Properties.Resources.dadoss;
            cmbx_CantJugadoress.DataSource = new List<JugadorPersona> { jugador};
            comboBox1.DataSource = new List<Jugador>(Sistema.Jugador);
            ActualizarListboxPartidas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de crear partida?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void btn_PartidaSimulado_Click(object sender, EventArgs e)
        {
                Sistema.InstanciarPartidaIA((JugadorPersona)cmbx_CantJugadoress.SelectedItem, (Jugador)comboBox1.SelectedItem);
                jugador.partidasJugadas++;
                ActualizarListboxPartidas();
        }
        private void ActualizarListboxPartidas()
        {
            this.listBox1.Items.Clear();
            foreach (Juego partida in Sistema.PartidasEnJuego)
            {
                listBox1.Items.Add(partida);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if(indice >= 0 && indice < Sistema.PartidasEnJuego.Count)
            {
                Juego partida = Sistema.PartidasEnJuego[indice];
                FormJugadorV2 form = new FormJugadorV2(partida);
                form.Show();
            }
        }
    }
}
