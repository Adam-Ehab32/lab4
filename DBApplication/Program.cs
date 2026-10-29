using System;
using System.Windows.Forms;

namespace DBapplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Supplier());
        }
    }
}
