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
    public partial class FormModificar : Form
    {
        JugadorPersona jugadorSeleccionado;
        AccesoDatos baseDatos;
        public FormModificar(JugadorPersona jugadorPersona)
        {
            InitializeComponent();
            this.jugadorSeleccionado = jugadorPersona;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            baseDatos = new AccesoDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_ModificarJugador_Click(object sender, EventArgs e)
        {
            string Nuevonombre = txt_nombre.Text;
            string Nuevoapellido = txt_apellido.Text;
            string Nuevousuario = txt_usuario.Text;
            string Nuevopassword = txt_password.Text;

            if(Validador.ValidarTexto(Nuevonombre) && Validador.ValidarTexto(Nuevoapellido) && Validador.ValidarTexto(Nuevousuario) && Validador.ValidarTexto(Nuevopassword))
            {
                jugadorSeleccionado.nombre = Nuevonombre;
                jugadorSeleccionado.apellido = Nuevoapellido;
                jugadorSeleccionado.usuario = Nuevousuario;
                jugadorSeleccionado.password = Nuevopassword;
                baseDatos.ModificarDato(jugadorSeleccionado);
                LimpiarTextBox();
                Hide();
            }

        }

        private void LimpiarTextBox()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_usuario.Text = "";
            txt_password.Text = "";
        }
    }
}
