using log4net.Config;
using log4net;
using System.Runtime.InteropServices;

namespace CalculatorApp
{
    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
#if DEBUG
            AllocConsole();
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root.RemoveAppender("FileAppender");
#else
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root.RemoveAppender("ConsoleAppender");
#endif

            ApplicationConfiguration.Initialize();
            Application.Run(new CalculatorForm());
        }
    }
}