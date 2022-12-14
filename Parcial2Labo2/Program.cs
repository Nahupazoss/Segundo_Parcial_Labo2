using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseParcial2;

namespace Parcial2Labo2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormInicioSesion());
            }
            catch(Exception)
            {
                MessageBox.Show("Error inesperado","Error");
                Application.Exit();            
            }
        }
    }
}
