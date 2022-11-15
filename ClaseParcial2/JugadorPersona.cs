using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class JugadorPersona
    {
        string nombre;
        string apellido;
        string usuario;
        string password;
        int partidasGanadas;
        int partidasPerdidas;
        int partidasJugadas;

        public JugadorPersona(string nombre)
        {
            this.nombre = nombre;
        }

        public JugadorPersona(string nombre, string apellido, string usuario, string password, int partidasGanadas, int partidasPerdidas, int partidasJugadas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.password = password;
            this.partidasGanadas = partidasGanadas;
            this.partidasPerdidas = partidasPerdidas;
            this.partidasJugadas = partidasJugadas;
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }
        public int PartidasPerdidas
        {
            get
            {
                return this.partidasPerdidas;
            }
        }
        public int PartidasGanadas
        {
            get
            {
                return this.partidasGanadas;
            }
        }

        public bool CheckearPassword(string password)
        {
            return password == this.password;
        }

    }
}