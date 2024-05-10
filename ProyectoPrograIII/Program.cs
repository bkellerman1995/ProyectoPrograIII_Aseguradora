using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrograIII.Layers.UI;
using ProyectoPrograIII.Util;

namespace ProyectoPrograIII
{
    static class Program
    {
        /// <summary>
        /// Se inicia la aplicación  
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
