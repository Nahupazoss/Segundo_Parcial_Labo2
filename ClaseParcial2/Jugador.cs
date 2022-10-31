using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public abstract class Jugador
    {
        string nombre;
        string apellido;
        int partidasGanadas;
        int partidasPerdidas;

        public Jugador(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.partidasGanadas = 0;
            this.partidasPerdidas = 0;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int PartidasGanadas { get => partidasGanadas; }
        public int PartidasPerdidas { get => partidasPerdidas; }


    }
}
