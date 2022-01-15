using Core.Api;

namespace Core
{
    internal static class Program
    {
        //todo: replace with config file
        private static readonly Uri Api = new("https://polar-bear-server.herokuapp.com/api/detectBear");

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(new ServerBearSearching(Api)));
        }
    }
}