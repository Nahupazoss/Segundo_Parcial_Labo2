using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class JugadorPersona : Jugador
    {
        string usuario;
        string password;

        public JugadorPersona(string nombre,string apellido,string usuario, string password) : base(nombre,apellido)
        {
            this.usuario = usuario;
            this.password = password;
        }
        public string Usuario
        {
            get { return usuario; }
        }

        public bool CheckearPassword(string password)
        {
            return password == this.password;
        }
    }
}
