using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application
        /// <c>save</c> is form for saving seted color.
        /// <c>main</c> is main form for this program.
        /// <c>Info</c> is form about this program.
        /// <c>Form1</c> is load screen.
        /// <c>ArduinoEr</c>form for setting serial COM port.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new IntroForm());
             Application.Run(new main());
           
            //Application.Run(new ArduinoEr());
            // Application.Run(new save());           
            // Application.Run(new Info());


        }
    }
}
