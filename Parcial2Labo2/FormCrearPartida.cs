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
        FormPartida menuPartida;
        public FormCrearPartida()
        {
            InitializeComponent();
        }

        private void FormCrearPartida_Load(object sender, EventArgs e)
        {
            this.img_dados2.Image = Properties.Resources.dadoss;
            cmbx_CantJugadoress.DataSource = Enum.GetNames(typeof(CantJugador));
            menuPartida = new FormPartida();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de crear partida?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_JugarYa_Click(object sender, EventArgs e)
        {
            string nombreSala = textBox1.Text;
            
            if(Validador.ValidarTexto(nombreSala))
            {
                menuPartida.Show();
            }
            else
            {
                MessageBox.Show("Debes ponerle nombre a tu sala!");
            }
        }
    }
}
