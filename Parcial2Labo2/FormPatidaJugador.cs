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

namespace Parcial2Labo2
{
    public partial class FormPartida : Form
    {
        List<Image> imagenesDado;
        System.Media.SoundPlayer musicaTiradaDados;
        bool noPuedeTocarDados;
        public FormPartida()
        {
            InitializeComponent();
            imagenesDado = new List<Image>();
        }

        private void FormPartida_Load(object sender, EventArgs e)
        {
            System.IO.Stream audioDadosTirada = Properties.Resources.DadosMenu;
            musicaTiradaDados = new System.Media.SoundPlayer(audioDadosTirada);
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara0"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara1"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara2"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara3"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara4"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara5"));
            imagenesDado.Add((Image)Resources.ResourceManager.GetObject("cara6"));
            LimpiarDados();
            btn_2doTiro.Visible = false;
            btn_3erTiro.Visible = false;
            noPuedeTocarDados = true;
        }

        public void LimpiarDados()
        {
            for(int i = 0; i < 5; i++)
            {
                ((PictureBox)this.groupBox1.Controls[i]).Image = imagenesDado[0];
            }  
        }

        public void PrimerTiroDados()
        {
            int dado1,dado2,dado3,dado4,dado5;
            Random aleatorio = new Random();
            dado1 = aleatorio.Next(1, 7);
            dado2 = aleatorio.Next(1, 7);
            dado3 = aleatorio.Next(1, 7);
            dado4 = aleatorio.Next(1, 7);
            dado5 = aleatorio.Next(1, 7);

            this.img_1.Image = imagenesDado[dado1];
            this.img_2.Image = imagenesDado[dado2];
            this.img_3.Image = imagenesDado[dado3];
            this.img_4.Image = imagenesDado[dado4];
            this.img_5.Image = imagenesDado[dado5];
            this.img_1.Visible = true;
            this.img_2.Visible = true;
            this.img_3.Visible = true;
            this.img_4.Visible = true;
            this.img_5.Visible = true;
        }

        public void TiroDeDadoElegido()
        {
            int dado1, dado2, dado3, dado4, dado5;
            Random aleatorio = new Random();
            dado1 = aleatorio.Next(1, 7);
            dado2 = aleatorio.Next(1, 7);
            dado3 = aleatorio.Next(1, 7);
            dado4 = aleatorio.Next(1, 7);
            dado5 = aleatorio.Next(1, 7);

            if(img_1.Visible == false)
            {
                this.img_1.Image = imagenesDado[dado1];
                this.img_1.Visible = true;
            }
            if(img_2.Visible == false)
            {
                this.img_2.Image = imagenesDado[dado2];
                this.img_2.Visible = true;
            }
            if(img_3.Visible == false)
            {
                this.img_3.Image = imagenesDado[dado3];
                this.img_3.Visible = true;
            }
            if(img_4.Visible == false)
            {
                this.img_4.Image = imagenesDado[dado4];
                this.img_4.Visible = true;
            }
            if(img_5.Visible == false)
            {
                this.img_5.Image = imagenesDado[dado5];
                this.img_5.Visible = true;
            }
            if(img_1.Visible == false && img_2.Visible == false && img_3.Visible == false && img_4.Visible == false && img_5.Visible == false)
            {
                PrimerTiroDados();
            }
        }

        private void btn_PrimerTiro(object sender, EventArgs e)
        {
            PrimerTiroDados();
            this.btn_tirar1.Visible = false;
            musicaTiradaDados.Play();
            btn_2doTiro.Visible = true;
            noPuedeTocarDados = false;
        }

        private void img_1_Click(object sender, EventArgs e)
        {
            if(noPuedeTocarDados)
            {
                return;
            }
            img_1.Visible = false;
        }

        private void img_2_Click(object sender, EventArgs e)
        {
            if(noPuedeTocarDados)
            {
                return;
            }
            img_2.Visible = false;
        }

        private void img_3_Click(object sender, EventArgs e)
        {
            if(noPuedeTocarDados)
            {
                return;
            }
            img_3.Visible = false;
        }

        private void img_4_Click(object sender, EventArgs e)
        {
            if(noPuedeTocarDados)
            {
                return;
            }
            img_4.Visible = false;
        }

        private void img_5_Click(object sender, EventArgs e)
        {
            if(noPuedeTocarDados)
            {
                return;
            }
            img_5.Visible = false;
        }

        private void btn_2doTiro_Click(object sender, EventArgs e)
        {
            TiroDeDadoElegido();
            btn_2doTiro.Visible = false;
            musicaTiradaDados.Play();
            btn_3erTiro.Visible = true;
            noPuedeTocarDados = false;
        }

        private void btn_3erTiro_Click(object sender, EventArgs e)
        {
            TiroDeDadoElegido();
            btn_3erTiro.Visible = false;
            musicaTiradaDados.Play();
            noPuedeTocarDados = true;
        }
    }
}
