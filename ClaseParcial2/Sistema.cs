using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public static class Sistema
    {
        static List<Jugador> jugadores;
        static List<JugadorPersona> jugadoresPersona;
        static List<JugadorIA> jugadorIA;

        static Sistema()
        {
            jugadores = new List<Jugador>();
            jugadoresPersona = new List<JugadorPersona>();
            jugadorIA = new List<JugadorIA>();
            HardCodeJugadorPersona();
            HardCodeJugadorIA();
        }

        private static void HardCodeJugadorPersona()
        {
            jugadoresPersona.Add(new JugadorPersona("Nahuel","Pazos", "NahuPaz", "123a"));
            jugadoresPersona.Add(new JugadorPersona("Maximiliano", "Neiner", "MaxiNei", "123aa"));
            jugadoresPersona.Add(new JugadorPersona("Facundo", "", "FacuRocha", "123aaa"));
        }

        private static void HardCodeJugadorIA()
        {
            jugadorIA.Add(new JugadorIA("Bot", "Mauro"));
            jugadorIA.Add(new JugadorIA("Bot", "Valery"));
            jugadorIA.Add(new JugadorIA("Bot", "Lucas"));
        }

        public static bool LoguearJugador(string usuario, string pass)
        {
            bool resultado = false;

            foreach (JugadorPersona item in jugadoresPersona)
            {
                if (item.Usuario == usuario)
                {
                    resultado = item.CheckearPassword(pass);
                }
            }
            return resultado;
        }

        public static void RegistrarJugador(string nombre, string apellido, string usuario, string pass)
        {
            jugadoresPersona.Add(new JugadorPersona(usuario, pass, nombre, apellido));  
        }





    }
}
