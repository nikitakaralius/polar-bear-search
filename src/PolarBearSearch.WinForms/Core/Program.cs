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
            IConfiguration configuration = Configuration();
            Application.Run(new MainForm(
                configuration.RemoteServer().Search(),
                configuration.DialogFilter()));
        }

        private static IConfiguration Configuration() => 
            new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
    }
}