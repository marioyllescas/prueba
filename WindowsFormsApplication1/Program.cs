using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string develop01 = string.Empty();

            develop01 = "test01";
            //develop01 = develop01.ToUpper();

            bool efectividad = true;
            bool visualizacion = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Ejecuta(ref bool efectividad){
            efectividad = false;
        }
    }
}
