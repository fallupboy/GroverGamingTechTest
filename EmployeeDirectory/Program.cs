using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EmployeeDirectory.Services;
using EmployeeDirectory.Services.Implementation;
using EmployeeDirectory.Models;
using EmployeeDirectory.Repositories;
using EmployeeDirectory.Repositories.Implementation;

namespace EmployeeDirectory
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddScoped<IEmployeeService, EmployeeService>();
                    services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                    services.AddTransient<MainForm>();
                    services.AddTransient<AddEmployeeForm>();
                    services.AddTransient<UpdateEmployeeForm>();
                    services.AddTransient<EmployeeContext>();
                });
        }
    }
}