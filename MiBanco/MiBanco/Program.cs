using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBanco
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
            //Application.Run(new Frm_Login());



            Frm_Login main = new Frm_Login();
            main.Show();
            Application.Run(); // quítale el parámetro aquí



            /*Application.Run(new frm_MClientes());*/

        }
    }
}
