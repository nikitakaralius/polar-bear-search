using Core.Extensions;
using Microsoft.Extensions.Configuration;

namespace Core
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(
                Configuration()
                .RemoteServer()
                .Search()));
        }

        private static IConfiguration Configuration() => 
            new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
    }
}