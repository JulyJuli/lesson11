using System;
using ConsoleApp3.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            Startup.ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var valerian = serviceProvider.GetService<IValerian>();
            var hunter = serviceProvider.GetService<IHunter>();
            var tail = serviceProvider.GetService<ITail>();

            var cat = new Cat(hunter, valerian);
            cat.Geeting();

            var dog = new Dog(hunter, tail);
            dog.Geeting();

            var catDog = new CatDog(hunter, tail, valerian);
            catDog.Geeting();
        }
    }
}