using ConsoleApp3.Implementations;
using ConsoleApp3.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp3
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHunter, ForestHunter>();
            services.AddSingleton<IValerian, Valerian>();
            services.AddSingleton<ITail, Tail>();
        }
    }
}