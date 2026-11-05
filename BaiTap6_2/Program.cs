using System;
using System.Windows.Forms;
using BaiTap6_2.GUI;

namespace BaiTap6_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}