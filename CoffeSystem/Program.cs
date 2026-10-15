using CoffeSystem_1UI.Login_Screen;
using CoffeSystem_1UI.Screens;
namespace CoffeSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
                 Application.Run(new frmLoginScreen());
            // Application.Run(new frmProducts());
            //  Application.Run(new frmOrders());



        }
    }
}