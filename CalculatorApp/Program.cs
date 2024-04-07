using CalculatorApp.Calculator.Command;
using CalculatorApp.Repositories;
using log4net;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;
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

            var services = new ServiceCollection();
            ConfigureServices(services);

            ApplicationConfiguration.Initialize();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<CalculatorForm>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<CalculatorForm>();
            services.AddTransient<CommandManager>();
            services.AddTransient<IHistoryRepository, HistoryRepository>();
            //services.AddSingleton<IHistoryRepository, InMemoryHistoryRepository>();
        }
    }
}