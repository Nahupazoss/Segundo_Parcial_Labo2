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
    public partial class FormMenuPrincipal : Form
    {
        FormInicioSesion menuInicioSesion;
        FormCrearPartida menuCrearPartida;
        FormEstadisticas menuEstadisticas;
        FormHistorial menuHistorial;
        FormAyuda menuAyuda;
        System.Media.SoundPlayer menuInicioMusica;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public FormMenuPrincipal(string mensaje) : this()
        {
            this.lbl_Bienvenida.Text = mensaje;
        }

        public string Mensaje
        {
            set { this.lbl_Bienvenida.Text = value; }
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.img_menu.Image = Properties.Resources.imagenmenu;
            menuInicioSesion = new FormInicioSesion();
            menuCrearPartida = new FormCrearPartida();
            menuEstadisticas = new FormEstadisticas();
            menuHistorial = new FormHistorial();
            menuAyuda = new FormAyuda();
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
            System.IO.Stream audioMenu = Properties.Resources.DadosMenu;
            menuInicioMusica = new System.Media.SoundPlayer(audioMenu);
            menuInicioMusica.Play();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al inicio de sesion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Close();
                menuInicioSesion.Show();
            }
        }

        private void btn_CrearPartida_Click(object sender, EventArgs e)
        {
            menuCrearPartida.Show();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            menuEstadisticas.Show();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            menuAyuda.Show();
        }

        private void btn_HistorialPartidas_Click(object sender, EventArgs e)
        {
            menuHistorial.Show();
        }
    }
}
