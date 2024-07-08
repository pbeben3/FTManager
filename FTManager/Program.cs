using FTManager.Models;
using FTManager.Presenters;
using FTManager.Repositories;
using FTManager.Views;
using System.Configuration;

namespace FTManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView loginView = new LoginView();
            IUserRepository repository = new UserRepository(sqlConnectionString);
            new LoginPresenter(loginView, repository, sqlConnectionString);
            Application.Run((Form)loginView);
        }
    }
}