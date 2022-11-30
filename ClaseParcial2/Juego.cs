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
        CancellationTokenSource  cancelarTask = new CancellationTokenSource();
        Task tarea;
        private int ronda;
        private string ganador;
        private Random random;
        private JugadorPersona jugadorUno;
        private Jugador jugadorDos;
        int flag;

        public event Action<List<int>> SeTiraronDados;
        public event Action<string> MandarMensaje;
        public event EventHandler TerminoPartida;

        public Juego(JugadorPersona jugadorUno, Jugador jugadorDos)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            ronda = 1;
            random = new Random();
            tarea = new Task(()=>Jugar(cancelarTask.Token),cancelarTask.Token);
            flag = 0;
        }
        public string Ganador
        {
            get { return this.ganador; }
        }
        public int Ronda { get => ronda; }
      
        public int ComenzarPartida()
        {
            tarea.Start();
            this.flag = 1;
            return flag;
            
        }
        public int CancelarPartida()
        {
            cancelarTask.Cancel();
            this.flag = -1;
            return flag;
        }
        private void Jugar(CancellationToken cancelarToken)
        {
            while(true)
            {
                MandarMensaje?.Invoke($"Se esta jugando la ronda {ronda}\n");
                Thread.Sleep(1000);
                JugarUnaRonda(jugadorUno, jugadorDos);

                if (ronda == 2 || cancelarToken.IsCancellationRequested)
                {
                    flag = -1;
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

        private void JugarUnaRonda(JugadorPersona unJugador, Jugador otroJugador)
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

            MandarMensaje?.Invoke($"{unJugador.usuario} tiro 5 dados y sumo en total {puntosJugadorUno}\n");
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
                   ganador = $"{unJugador.usuario} gano la ronda con {puntosJugadorUno}!\n";                  
                }
                else
                {
                    ganador = $"{otroJugador.Nombre} gano la ronda con {puntosJugadorDos}!\n";               
                }
            }
           
            Thread.Sleep(2000);
            MandarMensaje?.Invoke($"Termino la ronda...\n");
            Thread.Sleep(2000);
        }

        public override string ToString()
        {   
            return $"Jugador 1: {jugadorUno} Jugador 2: {jugadorDos}";  
        }
    }
}
