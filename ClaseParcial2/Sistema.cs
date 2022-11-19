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
        static AccesoDatos accesoDatosJugador; 

        public static JugadorPersona JugadorLogueado { get => jugadorLogueado; set => jugadorLogueado = value; }
        public static List<JugadorPersona> JugadorPersona { get => jugadoresPersona; }
        public static List<Jugador> Jugador { get => jugador; }
        static Sistema()
        {
            accesoDatosJugador = new AccesoDatos();
            jugador = new List<Jugador>();
            jugadoresPersona = accesoDatosJugador.ObtenerListaDato();
            HardCodeJugadorPersona();
            HardCodeJugadorIA();
        }

        public static List<JugadorPersona> ObtenerJugadoresPersona()
        {
            jugadoresPersona = accesoDatosJugador.ObtenerListaDato();
            return jugadoresPersona;
        }

        private static void HardCodeJugadorPersona()
        {
            jugadoresPersona.Add(new JugadorPersona(1,"Nahuel","Pazos", "NahuPaz", "123a",10,10,0));
            jugadoresPersona.Add(new JugadorPersona(2, "Mateo", "Zarza", "MateZarza", "123aa", 10, 10, 0));
        }

        private static void HardCodeJugadorIA()
        {
            jugador.Add(new Jugador("BotMauro",0));
            jugador.Add(new Jugador("BotValery",0));
            jugador.Add(new Jugador("BotNeiner",0));
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
       
    }
}
