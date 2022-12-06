using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class Dado
    {
        private int numero;

        public Dado()
        {
            this.numero = 0;
        }

        public int Numero // para devolver el numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        /// Metodo que simula la tirada del dado, asigna un valor random entre 1 y 6 incluidos
        public void Lanzar(Random R)
        {
            this.numero = R.Next(1, 7);
        }

        #region Generala
        /// Verifica si En la jugada de dados que recibe esta la jugada generala
        /// es decir, que hayan salido 5 dados iguales
        public static bool Generala(int[] mapeoDados)
        {
            bool esGenerala = false;

            for (int i = 0; i < 6; i++)
            {
                if (mapeoDados[i] == 5)
                {
                    esGenerala = true;
                    break;
                }
            }

            return esGenerala;
        }
        #endregion

        #region escalera
        ///  Verifica si En la jugada de dados que recibe esta la jugada escalera
        /// es decir, que hayan salido todos los dados distintos
        public static bool Escalera(List<int> dados)
        {
            bool esEscalera = false;
            if (dados[0] != dados[1] &&
                 dados[0] != dados[2] &&
                 dados[0] != dados[3] &&
                 dados[0] != dados[4])
            {
                if (dados[1] != dados[2] &&
                    dados[1] != dados[3] &&
                    dados[1] != dados[4])
                {
                    if (dados[2] != dados[3] &&
                        dados[2] != dados[4])
                    {
                        if (dados[3] != dados[4])
                        {
                            esEscalera = true;
                        }
                    }
                }

            }
            return esEscalera;
        }
        #endregion

        #region poker

        ///  Verifica si En la jugada de dados que recibe esta la jugada poker
        /// es decir, que hayan salido al menos 4 dados iguales
        public static bool Poker(int[] mapeoDados)
        {
            bool esPoker = false;          

            for (int i = 0; i < 6; i++)
            {
                if (mapeoDados[i] == 4)
                {
                    esPoker = true;
                    break;
                }
            }

            return esPoker;
        }

        public static int[] MapearJugada(List<int> dados)
        {
            int[] contadorDeLados = new int[6];
            for (int i = 0; i < 5; i++)
            {
                contadorDeLados[dados[i] - 1]++;
            }

            return contadorDeLados;
        }
        #endregion

        #region full
        ///  Verifica si En la jugada de dados que recibe esta la jugada full
        /// es decir, que hayan salido 3 dados iguales y 2 iguales distintos al anterior

        public static bool Full(int[] mapeoDados)
        {
            bool esFull = false;

            for (int i = 0; i < 6; i++)
            {
                if (mapeoDados[i] == 3 && mapeoDados[i] == 2)
                {
                    esFull = true;
                    break;
                }
            }

            return esFull;
        }
        #endregion

        /// metodo que verifica  la cantidad de veces que salio un numero en una tirada de dados 
        /// es decir si salieron 3-3-4-5-1 , me devuelve que el 3 salio 2 veces, el 4,5 y1 solo una vez
        /// para despues poder ver cual me conviene guardar, si el q mas salio o el q no. no es lo mismo 
        /// guardar uno al 1, que guardar seis al 3
        public static int VerificarPuntuacionNumero(List<int> dados, int numero)
        {
            int contador = 0;
            for (int i = 0; i < dados.Count; i++)
            {
                if (dados[i] == numero)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
