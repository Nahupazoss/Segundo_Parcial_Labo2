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
    public partial class FormHistorialJugadoresPersona : Form
    {
        AccesoDatos baseDatos;
        List<JugadorPersona> jugadores;
        FormInicioSesion menuInicio;
        FormModificar menuModificar;
        SerializadorJson<List<PartidaTerminada>> serializadorJson;
        SerializadorXml<List<PartidaTerminada>> serializadorXml;
        public FormHistorialJugadoresPersona()
        {
            InitializeComponent();
        }

        private void FormHistorialJugadoresPersona_Load(object sender, EventArgs e)
        {
            baseDatos = new AccesoDatos();
            jugadores = new List<JugadorPersona>();
            menuInicio = new FormInicioSesion();
            serializadorJson = new SerializadorJson<List<PartidaTerminada>>("Jugadores.json");
            serializadorXml = new SerializadorXml<List<PartidaTerminada>>("Jugadores.xml");
            ActualizarDataGrid();
        }
        
        private void ActualizarDataGrid()
        {
            this.dtgv_jugadoresPersona.DataSource = null;
            jugadores = baseDatos.ObtenerListaDato();
            this.dtgv_jugadoresPersona.DataSource = jugadores;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                JugadorPersona jugadorSeleccionado = (JugadorPersona)dtgv_jugadoresPersona.SelectedRows[0].DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea eliminar al jugador?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    baseDatos.EliminarDato(jugadorSeleccionado.id);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No seleccionaste ningun jugador", "!!!!");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                JugadorPersona jugadorSeleccionado = (JugadorPersona)dtgv_jugadoresPersona.SelectedRows[0].DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea modificar al jugador?", "Eliminación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    menuModificar = new FormModificar(jugadorSeleccionado);
                    menuModificar.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No seleccionaste ningun jugador","!!!!");
            }  
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Hide();
            menuInicio.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btn_SerializarJSON_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de serializar el historial en JSON", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                if (jugadores == null)
                {
                    MessageBox.Show("Contacte con el soporte");
                    return;
                }

                if (jugadores.Count < 1)
                {
                    MessageBox.Show("Lista vacia,no se puede serializar");
                    return;
                }

                //serializadorJson.Serializar(jugadores);
                MessageBox.Show("Se serializo con exito,se ha generado el archivo en el escritorio");
            }
        }
    }
}
