using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class SalaDeJuego
    {
        string name;
        Jugador jugador1;
        Jugador jugador2;
        string estado;

        public SalaDeJuego(string name, Jugador jugador1, Jugador jugador2,string estado)
        {
            this.name = name;
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.estado = estado;
        }




    }
}
