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
    public partial class FormInicioSesion : Form
    {
        System.Media.SoundPlayer musicaEspera;
        FormRegistro menuRegistro;
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.imgn_inicio.Image = Image.FromFile(@"C:\Users\Rodri\source\repos\Parcial2Labo2\Imagenes\ImagenInicio.gif");
            lbl_MsgError.Visible = false;
            img_SonidoDesactivado.Visible = false;
            System.IO.Stream audioEspera = Properties.Resources.MusicaEspera;
            musicaEspera = new System.Media.SoundPlayer(audioEspera);
            musicaEspera.Play();
            menuRegistro = new FormRegistro();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la Aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text;
            string pass = txt_Pass.Text;

            if(Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass) && Sistema.LoguearJugador(usuario,pass))
            {
                FormMenuPrincipal menuPrincipal = new FormMenuPrincipal($"¡Bienvenido {usuario}!");

                menuPrincipal.Show();
                Hide();

                lbl_MsgError.Visible = false;
            }
            else
            {
                lbl_MsgError.Visible = true;
            }
        }

        private void img_SonidoActivo_Click(object sender, EventArgs e)
        {
            img_SonidoActivo.Visible = false;
            img_SonidoDesactivado.Visible = true;
            musicaEspera.Stop();
        }

        private void img_SonidoDesactivado_Click(object sender, EventArgs e)
        {
            img_SonidoActivo.Visible = true;
            img_SonidoDesactivado.Visible = false;
            musicaEspera.Play();
        }

        private void btn_Invitado_Click(object sender, EventArgs e)
        {
            string usuario = "Invitado";

            if (Validador.ValidarTexto(usuario))
            {
                FormMenuPrincipal menuPrincipal = new FormMenuPrincipal($"¡Bienvenido {usuario}!");

                menuPrincipal.Show();
                Hide();

                lbl_MsgError.Visible = false;
            }
            else
            {
                lbl_MsgError.Visible = true;
            }
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            Hide();
            menuRegistro.Show();
            musicaEspera.Stop();
        }

        private void btn_AutoComplete_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "NahuPaz";
            txt_Pass.Text = "123a";
        }
    }
}
