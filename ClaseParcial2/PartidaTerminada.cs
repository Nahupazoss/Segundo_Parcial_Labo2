using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class PartidaTerminada
    {
        int id;
        string jugador1;
        string jugador2;
        int puntaje1;
        int puntaje2;
        string ganador;
        public PartidaTerminada()
        {
            this.jugador1 = " ";
            this.jugador2 = " ";
            this.puntaje1 = 0;
            this.puntaje2 = 0;
            this.ganador = " ";
        }

        public PartidaTerminada(string jugador1, string jugador2,int puntaje1,int puntaje2,string ganador)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.puntaje1 = puntaje1;
            this.puntaje2 = puntaje2;
            this.ganador = ganador; 
        }

        public PartidaTerminada(int id,string jugador1, string jugador2, int puntaje1, int puntaje2, string ganador)
        {
            this.id = id;
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.puntaje1 = puntaje1;
            this.puntaje2 = puntaje2;
            this.ganador = ganador;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Jugador1 { get => jugador1; set => jugador1 = value; }
        public string Jugador2 { get => jugador2; set => jugador2 = value; }
        public int Puntaje1 { get => puntaje1; set => puntaje1 = value; }
        public int Puntaje2 { get => puntaje2; set => puntaje2 = value; }
        public string Ganador { get => ganador; set => ganador = value; }
    }
}

