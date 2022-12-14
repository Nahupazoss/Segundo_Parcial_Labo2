using Parcial2Labo2.Properties;
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
using System.Media;
using System.Threading;

namespace Parcial2Labo2
{
    public partial class FormJugadorV2 : Form
    {
        Juego juego;
        SoundPlayer reproductor;
        List<Image> imagenesDado;
        public FormJugadorV2(Juego juego)
        {
            InitializeComponent();
            this.juego = juego;
            imagenesDado = new List<Image>();
        }
        private void FormJugadorV2_Load(object sender, EventArgs e)
        {
            reproductor = new SoundPlayer();
            juego.MandarMensaje += ImprimirMensaje;
            juego.TerminoPartida += ImprimirResultado;
            juego.SeTiraronDados += MostrarDados;
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara0"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara1"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara2"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara2"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara3"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara4"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara5"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara6"));
            LimpiarDados();
        }

        private void ImprimirMensaje(string mensaje)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ImprimirMensaje), mensaje);
            }
            else
            {
                this.richtxtbox_partida.Text = this.richtxtbox_partida.Text.Insert(0, mensaje);
            }
        }

        private void ImprimirResultado(object sender, EventArgs e)
        {
            Juego juego = (Juego)sender;
            if(juego.Puntaje1 > juego.Puntaje2)
            {
                MessageBox.Show($"El ganador es: {juego.Ganador} con {juego.Puntaje1} puntos");
            }
            else
            {
                MessageBox.Show($"El ganador es: {juego.Ganador} con {juego.Puntaje2} puntos");
            }
            LimpiarDados();
        }

        private void MostrarDados(List<int> listaDeDados)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    if (listaDeDados[i] == 1)
                    {
                        ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[1];
                    }
                    else if (listaDeDados[i] == 2)
                    {
                        ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[2];
                    }
                    else if (listaDeDados[i] == 3)
                    {
                        ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[3];
                    }
                    else if (listaDeDados[i] == 4)
                    {
                        ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[4];
                    }
                    else if (listaDeDados[i] == 5)
                    {
                        ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[5];
                    }
                    else if (listaDeDados[i] == 6)
                    {
                        ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[6];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado", "Error");
                Application.Exit();
            }
           
        }

        public void LimpiarDados()
        {
            for (int i = 0; i < 5; i++)
            {
                ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[0];
            }
        }

        private void btn_tirar1_Click(object sender, EventArgs e)
        {
            juego.ComenzarPartida();
            btn_tirar1.Enabled = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de minimizar la partida?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Si sales de la partida perderas automaticamente!! Estas seguro de abandonar?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                juego.CancelarPartida();
                Hide();
            }
        }
    }
}
