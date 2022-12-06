using System;
using System.Collections.Generic;
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
        public event Action<Juego> GuardarPartida;

        public Juego(JugadorPersona jugadorUno, Jugador jugadorDos)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            ronda = 1;
            random = new Random();
            tarea = new Task(() =>
            {
                Jugar(cancelarTask.Token);
                GuardarPartida?.Invoke(this);
            },cancelarTask.Token);
            flag = 0;
        }

        public JugadorPersona JugadorUno
        {
            get
            {
                return this.jugadorUno;
            }
        }

        public Jugador JugadorDos
        {
            get
            {
                return this.jugadorDos;
            }
        }

        public int Puntaje1 { get; set; }
        public int Puntaje2 { get; set; }

        public string Ganador
        {
            get { return this.ganador; }
            set { this.ganador = value;  }
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
                string nombre1 = jugadorUno.usuario;
                string nombre2 = jugadorDos.Nombre;

                if (ronda == 2 || cancelarToken.IsCancellationRequested)
                {
                    flag = -1;
                    break;
                }
                ronda++;
            }
            if (TerminoPartida is not null)
            {
                if(Puntaje1 > Puntaje2)
                {
                    Ganador = jugadorUno.nombre;
                    MandarMensaje?.Invoke($"{jugadorUno.nombre} gana la partida!");
                } else
                {
                    if(Puntaje2 > Puntaje1)
                    {
                        Ganador = jugadorDos.Nombre;
                        MandarMensaje?.Invoke($"{jugadorDos.Nombre} gana la partida!");
                    }
                    else
                    {
                        Ganador = "Empate";
                        MandarMensaje?.Invoke("No hubo ganador...");
                    }
                }
                TerminoPartida(this, EventArgs.Empty);
            }
        }

        private int CalcularSumaDeLosDados(List<int> dados, out string nombreJugada)
        {
            int puntaje = 0;
            int[] mapeadoDados = Dado.MapearJugada(dados);
            nombreJugada = "Ninguna";


            if(Dado.Poker(mapeadoDados))
            {
                puntaje = 40;
                nombreJugada = "Poker";
            }
            else
            {
                if(Dado.Full(mapeadoDados))
                {
                    puntaje = 30;
                    nombreJugada = "Full";
                }
                else
                {
                    if(Dado.Escalera(dados))
                    {
                        puntaje = 20;
                        nombreJugada = "Escalera";
                    }
                    else
                    {
                        if(Dado.Generala(mapeadoDados))
                        {
                            puntaje = 50;
                            nombreJugada = "Generala";
                        }
                    }
                }
            }
            return puntaje;
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
            Thread.Sleep(1000);
            //reproductor.Stream = Resources.ResourceManager.GetStream("SonidoWinner");
            AsignarDados(dadosJugadorDos);
            Thread.Sleep(1000);

            string nombreJugada = "";
            int puntosJugadorUno = CalcularSumaDeLosDados(dadosJugadorUno, out nombreJugada);
            int puntosJugadorDos = CalcularSumaDeLosDados(dadosJugadorDos, out nombreJugada);

            Puntaje1 += puntosJugadorUno;
            Puntaje2 += puntosJugadorDos;

            MandarMensaje?.Invoke($"{unJugador.usuario} saco una {nombreJugada} y sumo en total {puntosJugadorUno}\n");
            MandarMensaje?.Invoke($"{otroJugador.Nombre} saco una {nombreJugada} y sumo en total {puntosJugadorDos}\n");

            Thread.Sleep(1000);
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
           
            Thread.Sleep(1000);
            MandarMensaje?.Invoke($"Termino la ronda...\n");
            Thread.Sleep(1000);
        }

        public override string ToString()
        {   
            return $"Jugador 1: {jugadorUno} Jugador 2: {jugadorDos}";  
        }

        public bool HayGanador(int puntaje1,int puntaje2)
        {
            bool resultado = false;
           



            return resultado;
        }

    }
}
