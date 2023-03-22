using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_BarrottM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //GDI for Graphics applications
            //The Microsoft Windows graphics device interface (GDI) enables applications to use graphics and formatted text on both the video display and the printer.
            //Windows-based applications do not access the graphics hardware directly.
            //Instead, GDI interacts with device drivers on behalf of applications.

            //DoubleBuffering
            //Double buffering uses a memory buffer to address the flicker problems associated with multiple paint operations.
            //When double buffering is enabled, all paint operations are first rendered to a memory buffer instead of the drawing surface on the screen.


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
