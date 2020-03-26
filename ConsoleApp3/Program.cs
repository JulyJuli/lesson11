using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
           
            Startup startup = new Startup();
            startup.ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var testInterface = serviceProvider.GetService<ITestInterface>();
        
            var cat = new Cat(testInterface);
            cat.Can();
        }
    }
}