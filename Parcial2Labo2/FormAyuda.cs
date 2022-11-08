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
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
        }

        private void FormAyuda_Load(object sender, EventArgs e)
        {
            this.lbl_msgAyuda.Text = "El objetivo del juego es lograr la mayor puntuación, de acuerdo a un criterio \nde valoración establecido para cada jugada posible en el juego,\nllamada categoría" +
                "\nEl número de jugadores es ilimitado, pero lo óptimo es de 3 a 5." +
                "\nSe juega con 5 dados convencionales y 1 cubilete.Para anotar la puntuación de\ncada jugador, se debe armar una planilla donde figuren en las filas las 10 \ncategorías posibles, mientras que en las columnas se colocan los nombres\nde los jugadores.";
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
    }
}
