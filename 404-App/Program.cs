using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _404_App.Formularios;
using _404_App.Formularios.Acciones;

namespace _404_App
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
    }
}
