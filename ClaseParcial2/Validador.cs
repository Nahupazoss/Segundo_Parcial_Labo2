using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial2
{
    public class Validador
    {
        public static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato) && !string.IsNullOrWhiteSpace(dato);
        }
    }
}
