using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class JugadorPersona
    {
        public int id;
        public string nombre;
        public string apellido;
        public string usuario;
        public string password;
        public int partidasGanadas;
        public int partidasPerdidas;
        public int partidasJugadas;

        public JugadorPersona(string nombre, string apellido, string usuario, string password, int partidasGanadas, int partidasPerdidas, int partidasJugadas)
        {
            this.id = 0;
            this.nombre = nombre;
            this.apellido = apellido;
            this.usuario = usuario;
            this.password = password;
            this.partidasGanadas = partidasGanadas;
            this.partidasPerdidas = partidasPerdidas;
            this.partidasJugadas = partidasJugadas;
        }

        public JugadorPersona()
        {
            this.nombre = " ";
            this.apellido = " ";
            this.usuario = " ";
            this.password = " ";
            this.partidasGanadas = 0;
            this.partidasPerdidas = 0;
            this.partidasJugadas = 0;
        }

        public JugadorPersona(int id,string nombre, string apellido, string usuario, string password, int partidasGanadas, int partidasPerdidas, int partidasJugadas)
        {
            this.id = id;
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
            set
            {
                this.password = value;
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