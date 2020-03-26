using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ITestInterface, TestImplementation>();
        }
        
    }
}