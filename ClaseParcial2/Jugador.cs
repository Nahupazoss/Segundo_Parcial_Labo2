using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class Jugador
    {
        string nombre;
        int rondasGanadas;

        public Jugador(string nombre, int rondasGanadas)
        {
            this.nombre = nombre;
            this.rondasGanadas = rondasGanadas;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int RondasGanadas
        {
            get
            {
                return this.rondasGanadas;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}";
        }
    }
}
