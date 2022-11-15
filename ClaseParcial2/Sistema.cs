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

        public static JugadorPersona JugadorLogueado { get => jugadorLogueado; set => jugadorLogueado = value; }
        public static List<JugadorPersona> JugadorPersona { get => jugadoresPersona; }
        public static List<Jugador> Jugador { get => jugador; }
        static Sistema()
        {
            jugadoresPersona = new List<JugadorPersona>();
            jugador = new List<Jugador>();
            //partidas = new List<LogicaJuego>();
            HardCodeJugadorPersona();
            HardCodeJugadorIA();
        }

        private static void HardCodeJugadorPersona()
        {
            jugadoresPersona.Add(new JugadorPersona("Nahuel","Pazos", "NahuPaz", "123a",10,10,0));
            jugadoresPersona.Add(new JugadorPersona("Maximiliano", "Neiner", "MaxiNei", "123aa",2,3,0));
            jugadoresPersona.Add(new JugadorPersona("Facundo", "", "FacuRocha", "123aaa",3,3,0));
        }

        private static void HardCodeJugadorIA()
        {
            jugador.Add(new Jugador("BotMauro",0));
            jugador.Add(new Jugador("BotValery",0));
            jugador.Add(new Jugador("BotNeiner",0));
        }
        private static void HardCodePartidas()
        {
            //partidas.Add(new LogicaJuego(jugadoresPersona[0],jugadorIA[0],10,10,10));
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
            jugadoresPersona.Add(new JugadorPersona(nombre, apellido, usuario, pass,0,0,0));  
        }
        
     
    }

}
