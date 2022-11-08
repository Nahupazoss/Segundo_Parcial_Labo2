using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class LogicaJuego
    {
        Jugador jugador1;
        JugadorIA jugador2;
        int cantidadRondas;
        int turnoJugador1;
        int turnoJugador2;
        Dictionary<string,int> jugadas;

        public LogicaJuego(Jugador jugador1, JugadorIA jugador2, int cantidadRondas, int turnoJugador1, int turnoJugador2)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.cantidadRondas = cantidadRondas;
            this.turnoJugador1 = turnoJugador1;
            this.turnoJugador2 = turnoJugador2;
            jugadas = new Dictionary<string, int>();
            this.jugadas.Add("1",0);
            this.jugadas.Add("2", 0);
            this.jugadas.Add("3", 0);
            this.jugadas.Add("4", 0);
            this.jugadas.Add("5", 0);
            this.jugadas.Add("6", 0);
            this.jugadas.Add("Escalera", 0);
            this.jugadas.Add("Full", 0);
            this.jugadas.Add("Poker", 0);
            this.jugadas.Add("Generala", 0);
            this.jugadas.Add("GenerelaDoble", 0);
        }

        public void JugarPartida()
        {
            while(cantidadRondas <= 10)
            {
                JugarRondaJugador(jugador1);
                JugarRondaIA(jugador2);
            }
        }

        public void JugarRondaJugador(Jugador jugador1)
        {

        }

        public void JugarRondaIA(JugadorIA jugador2)
        {

        }

        public void SeleccionarJugada()
        {


        }
    }
}
