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
    public partial class FormRegistro : Form
    {
        FormInicioSesion menuInicio;
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            this.img_dado3.Image = Properties.Resources.dadosss;
            menuInicio = new FormInicioSesion();
            lbl_MsgError.Visible = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea volver al menu de inicio de sesion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Close();
                menuInicio.Show();
            }
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nomb.Text;
            string apellido = txt_Apellido.Text;
            string usuario = txt_Username.Text;
            string password = txt_Password.Text;

            if(VerificarRegistro(nombre,apellido,usuario,password))
            {
                lbl_MsgError.Visible = false;
                Sistema.RegistrarJugador(nombre,apellido,usuario,password);
                MessageBox.Show($"{nombre} te has registrado con exito!!", "Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarTxtBox();
            }
            else
            {
                lbl_MsgError.Visible = true;
                MessageBox.Show("Verifique que tiene todos los datos bien ingresados\n\nRequisitos:\n-Ser mayor a 5 años de edad");
            }

        }

        private static bool VerificarRegistro(string nomb,string apellido, string usuario, string pass)
        {
            return Validador.ValidarTexto(nomb) && Validador.ValidarTexto(apellido) && Validador.ValidarTexto(usuario) && Validador.ValidarTexto(pass);
        }

        public void LimpiarTxtBox()
        {
            txt_Nomb.Text = "";
            txt_Apellido.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
    }
}
