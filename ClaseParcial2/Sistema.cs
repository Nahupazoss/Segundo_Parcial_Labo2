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
        static List<Jugador> jugador;
        static List<Juego> partidasEnJuego;
        static AccesoDatos accesoDatosJugador; 

        public static JugadorPersona JugadorLogueado { get => jugadorLogueado; set => jugadorLogueado = value; }
        public static List<JugadorPersona> JugadorPersona { get => jugadoresPersona; }
        public static List<Jugador> Jugador { get => jugador; }
        public static List<Juego> PartidasEnJuego { get => partidasEnJuego; }

        static Sistema()
        {
            accesoDatosJugador = new AccesoDatos();
            jugador = new List<Jugador>();
            partidasEnJuego = new List<Juego>();
            jugadoresPersona = accesoDatosJugador.ObtenerListaDato();
            HardCodeJugadorIA();
        }

        public static List<JugadorPersona> ObtenerJugadoresPersona()
        {
            jugadoresPersona = accesoDatosJugador.ObtenerListaDato();
            return jugadoresPersona;
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

        public static void InstanciarPartidaIA(Jugador jugador1 , Jugador jugador2)
        {
            partidasEnJuego.Add(new Juego(jugador1, jugador2));
        }

        /*public static void InstanciarPartida(Jugador jugador1, Jugador jugador2)
        {
            partidasEnJuego.Add(new Juego(jugador1, jugador2));
        }*/

    }
}
