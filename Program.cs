using FarmManagementApp;
using ManagerApp.Entities;
using ManagerApp.Factories;
using ManagerApp.Interfaces;

namespace ManagerApp
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}