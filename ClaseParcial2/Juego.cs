using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class Juego
    {
        Task tarea;
        private int ronda;
        private string ganador;
        private Random random;
        private Jugador jugadorUno;
        private Jugador jugadorDos;

        public event Action<List<int>> SeTiraronDados;
        public event Action<string> MandarMensaje;
        public event EventHandler TerminoPartida;

        public Juego(Jugador jugadorUno, Jugador jugadorDos)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            ronda = 1;
            random = new Random();
            tarea = new Task(Jugar);
        }
        public string Ganador
        {
            get { return this.ganador; }
        }
        public void ComenzarPartida()
        {
            tarea.Start();
        }

        private void Jugar()
        {
            while (true)
            {
                //if (jugadorQueEmpezoLaRondaAnterior == jugadorUno)
                //{
                //    // Los intercambio
                //    Jugador aux = jugadorUno;
                //    jugadorUno = jugadorDos;
                //    jugadorDos = aux;
                //}
                MandarMensaje?.Invoke($"Se esta jugando la ronda {ronda}\n");
                Thread.Sleep(1000);
                //jugadorQueEmpezoLaRondaAnterior = jugadorUno;
                JugarUnaRonda(jugadorUno, jugadorDos);
                if (ronda == 10)
                {
                    ganador = "El que gano {}\n";
                    break;
                }
                ronda++;
            }
            if (TerminoPartida is not null)
            {
                TerminoPartida(this, EventArgs.Empty);
            }
        }

        private int CalcularSumaDeLosDados(List<int> dados)
        {
            int acumulador = 0;
            for (int i = 0; i < 5; i++)
            {
                acumulador += dados[i];
            }
            return acumulador;
        }

        private void AsignarDados(List<int> listaDeDados)
        {
            for (int i = 0; i < 5; i++)
            {
                listaDeDados.Add(random.Next(1, 7));
            }
            if (SeTiraronDados is not null)
            {
                SeTiraronDados(listaDeDados);
            }
        }
        private void Mensaje(string mensaje)
        {

        }

        private void JugarUnaRonda(Jugador unJugador, Jugador otroJugador)
        {
            Action<string> miDelegado = Mensaje;
            miDelegado += Mensaje;
            miDelegado += Mensaje;

            var miVariable = miDelegado.GetInvocationList();

            miDelegado.Invoke("hola");

            List<int> dadosJugadorUno = new List<int>();
            List<int> dadosJugadorDos = new List<int>();

            //reproductor.Stream = Resources.ResourceManager.GetStream("SonidoWinner");
            AsignarDados(dadosJugadorUno);
            Thread.Sleep(2000);
            //reproductor.Stream = Resources.ResourceManager.GetStream("SonidoWinner");
            AsignarDados(dadosJugadorDos);
            Thread.Sleep(2000);

            int puntosJugadorUno = CalcularSumaDeLosDados(dadosJugadorUno);
            int puntosJugadorDos = CalcularSumaDeLosDados(dadosJugadorDos);

            MandarMensaje?.Invoke($"{unJugador.Nombre} tiro 5 dados y sumo en total {puntosJugadorUno}\n");
            MandarMensaje?.Invoke($"{otroJugador.Nombre} tiro 5 dados y sumo en total {puntosJugadorDos}\n");
            Thread.Sleep(2000);
            if (puntosJugadorUno == puntosJugadorDos)
            {
                MandarMensaje?.Invoke($"Empate!\n");
            }
            else
            {
                if (puntosJugadorUno > puntosJugadorDos)
                {
                    MandarMensaje?.Invoke($"{unJugador.Nombre} gano la ronda con {puntosJugadorUno}!\n");
                }
                else
                {
                    MandarMensaje?.Invoke($"{otroJugador.Nombre} gano la ronda con {puntosJugadorDos}!\n");
                }
            }
            Thread.Sleep(2000);
            MandarMensaje?.Invoke($"Termino la ronda...\n");
            Thread.Sleep(2000);
        }

    }
}
