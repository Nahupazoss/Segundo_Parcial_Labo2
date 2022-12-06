using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public static class Sistema
    {
        static JugadorPersona jugadorLogueado;
        static List<JugadorPersona> jugadoresPersona;
        static List<PartidaTerminada> historialPartidas;
        static List<Jugador> jugador;
        static List<Juego> partidasEnJuego;
        static AccesoDatos accesoDatosJugador;
        static AccesoDatosPartida accesoDatosHistorialPartidas;

        public static JugadorPersona JugadorLogueado { get => jugadorLogueado; set => jugadorLogueado = value; }
        public static List<JugadorPersona> JugadorPersona { get => jugadoresPersona; }
        public static List<PartidaTerminada> PartidaTerminada { get => historialPartidas; set => historialPartidas = value; }
        public static List<Jugador> Jugador { get => jugador; }
        public static List<Juego> PartidasEnJuego { get => partidasEnJuego; }

        static Sistema()
        {
            PartidaTerminada = new List<PartidaTerminada>();
            accesoDatosJugador = new AccesoDatos();
            accesoDatosHistorialPartidas = new AccesoDatosPartida();
            jugador = new List<Jugador>();
            partidasEnJuego = new List<Juego>();
            jugadoresPersona = accesoDatosJugador.ObtenerListaDato();
            historialPartidas = accesoDatosHistorialPartidas.ObtenerListaDato();
            HardCodeJugadorIA();
        }

        public static List<JugadorPersona> ObtenerJugadoresPersona()
        {
            jugadoresPersona = accesoDatosJugador.ObtenerListaDato();
            return jugadoresPersona;
        }

        public static List<PartidaTerminada> ObtenerPartidasTerminas()
        {
            historialPartidas = accesoDatosHistorialPartidas.ObtenerListaDato();
            return historialPartidas;
        }

        private static void HardCodeJugadorIA()
        {
            jugador.Add(new Jugador("BotMauro", 0));
            jugador.Add(new Jugador("BotValery", 0));
            jugador.Add(new Jugador("BotNeiner", 0));
            jugador.Add(new Jugador("BotNahuel", 0));
            jugador.Add(new Jugador("BotNathan", 0));
            jugador.Add(new Jugador("BotMica", 0));
        }

        public static bool LoguearJugador(string usuario, string pass )
        {
            bool resultado = false;

            foreach (JugadorPersona item in jugadoresPersona)
            {
                if (item.Usuario == usuario)
                {
                    resultado = item.CheckearPassword(pass);
                    Sistema.JugadorLogueado = item;
                }
            }
            return resultado;
        }

        public static void RegistrarJugador(string nombre, string apellido, string usuario, string pass)
        {
            JugadorPersona jugador =  new JugadorPersona(nombre,apellido,usuario,pass,0,0,0);
            accesoDatosJugador.AgregarDato(jugador);
        }

        public static void InstanciarPartidaIA(JugadorPersona jugador1 , Jugador jugador2)
        {
            Juego partida = new Juego(jugador1, jugador2);
            partida.GuardarPartida += GuardarPartidaTerminadaEnBaseDeDatos;
            partidasEnJuego.Add(partida);
        }

        public static void GuardarPartidaTerminadaEnBaseDeDatos(Juego juego)
        {
            PartidaTerminada partidaTerminada = new PartidaTerminada(juego.JugadorUno.nombre, juego.JugadorDos.Nombre, juego.Puntaje1, juego.Puntaje2, juego.Ganador);
            AccesoDatosPartida partidasAdo = new AccesoDatosPartida();
            partidasAdo.AgregarDato(partidaTerminada);
            PartidaTerminada = partidasAdo.ObtenerListaDato();
        }

        /*public static void InstanciarPartida(Jugador jugador1, Jugador jugador2)
        {
            partidasEnJuego.Add(new Juego(jugador1, jugador2));
        }*/

    }
}
