using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class PartidaTerminada
    {
        Jugador jugador1;
        Jugador jugador2;
        Jugador ganador;
        int cantidadRondas;

        public PartidaTerminada(Jugador jugador1, Jugador jugador2, Jugador ganador, int cantidadRondas)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.ganador = ganador;
            this.cantidadRondas = cantidadRondas;
        }
    }
}
