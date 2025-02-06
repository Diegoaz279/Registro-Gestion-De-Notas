using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Gestion_De_Notas
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fromestudiante = new FormCursos();
            if (fromestudiante.ShowDialog() == DialogResult.OK)
            {
                
                var estudiantes = new FormEstudiantes(); // Instancia del formulario principal
                Application.Run(estudiantes); // Ejecuta la aplicación con el formulario principal. ¡Solo se llama una vez!
            }
            else
            {
                // Si el login falla o se cancela, la aplicación termina.
                Application.Exit(); // Cierra la aplicación 
            }
        }
    }
}
