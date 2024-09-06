using System;
using System.Windows.Forms;

namespace OfdRuErrorParser
{
    internal static class Program
    {
        public static Form1 main;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new Form1();
            Application.Run(main);
        }
    }
}
