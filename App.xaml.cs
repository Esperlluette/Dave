using NLog;

namespace Dave
{
    public partial class App : Application
    {
        public static readonly string logDefault = @"C:\\Users\\janlm\\source\\repos\\Dave\\bin\\Debug\\net8.0-windows10.0.19041.0\\win10-x64\\logs\\log.log";
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
