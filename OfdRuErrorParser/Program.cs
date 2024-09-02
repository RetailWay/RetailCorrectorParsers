using System;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace OfdRuErrorParser
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
