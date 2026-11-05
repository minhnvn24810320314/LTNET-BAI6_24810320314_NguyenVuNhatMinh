using System;
using System.Windows.Forms;
using BaiTap6_1.GUI;

namespace BaiTap6_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain()); // Chạy FormMain
        }
    }
}