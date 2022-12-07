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
    public partial class FormHistorial : Form
    {
        SerializadorJson<List<PartidaTerminada>> serializadorJson;
        SerializadorXml<List<PartidaTerminada>> serializadorXml;
        AccesoDatosPartida basedatosPartida;
        List<PartidaTerminada> partidas;
        public FormHistorial()
        {
            InitializeComponent();
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

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            basedatosPartida = new AccesoDatosPartida();
            partidas = new List<PartidaTerminada>();
            serializadorJson = new SerializadorJson<List<PartidaTerminada>>("PartidasTerminadas.json");
            serializadorXml = new SerializadorXml<List<PartidaTerminada>>("PartidasTerminadas.xml");
            ActualizarDataGrid();
        }

        public void ActualizarDataGrid()
        {
            if(basedatosPartida != null)
            {
                dtgv_historial.DataSource = null;
                partidas = basedatosPartida.ObtenerListaDato();
                dtgv_historial.DataSource = partidas;
            }
        }

        private void btn_SerializarXml_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de serializar el hitorial en  XML?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                if(partidas == null)
                {
                    MessageBox.Show("Contacte con el soporte");
                    return;
                }
                
                if(partidas.Count < 1)
                {
                    MessageBox.Show("Lista vacia,no se puede serializar");
                    return;
                }
               
                serializadorXml.Serializar(partidas);
                MessageBox.Show("Se serializo con exito,se ha generado el archivo en el escritorio");
            }
        }

        private void btn_SerializarJson_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de serializar el historial en JSON", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                if (partidas == null)
                {
                    MessageBox.Show("Contacte con el soporte");
                    return;
                }

                if (partidas.Count < 1)
                {
                    MessageBox.Show("Lista vacia,no se puede serializar");
                    return;
                }

                serializadorJson.Serializar(partidas);
                MessageBox.Show("Se serializo con exito,se ha generado el archivo en el escritorio");
            }
        }

        private void btn_DeserializarJSON(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de deserializar el hitorial en  XML?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                if (partidas == null)
                {
                    MessageBox.Show("Contacte con el soporte");
                    return;
                }

                if (partidas.Count < 1)
                {
                    MessageBox.Show("Lista vacia,no se puede serializar");
                    return;
                }

                serializadorJson.Deserializar();
                MessageBox.Show("Se serializo con exito,se ha generado el archivo en el escritorio");
            }
        }

        private void btn_DeserializarXml_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Estas seguro de deserializar el hitorial en  XML?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                if (partidas == null)
                {
                    MessageBox.Show("Contacte con el soporte");
                    return;
                }

                if (partidas.Count < 1)
                {
                    MessageBox.Show("Lista vacia,no se puede serializar");
                    return;
                }

                serializadorXml.Deserializar();
                MessageBox.Show("Se serializo con exito,se ha generado el archivo en el escritorio");
            }
        }
    }
}
