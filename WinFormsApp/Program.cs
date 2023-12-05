using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StreetPerfect.Http;
using System.Configuration;

namespace WinFormsApp
{
    internal static class Program
    {
        //public static IServiceProvider ServiceProvider { get; private set; } // do we need this?

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = Host.CreateDefaultBuilder();
            builder.ConfigureServices((context, services) =>
            {
                services.AddStreetPerfectClient(c =>
                {
                    c.ClientId = ConfigurationManager.AppSettings["sp_ClientId"];
                    c.ClientSecret = ConfigurationManager.AppSettings["sp_ClientSecret"];
                    //can change
                    //c.BaseAddress = ConfigurationManager.AppSettings["sp_BaseAddress"];
                });
                services.AddTransient<Form1>();

            });

            var host = builder.Build();

            Application.Run(host.Services.GetRequiredService<Form1>());
        }


    }
}