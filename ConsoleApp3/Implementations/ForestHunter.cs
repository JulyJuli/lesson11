using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Implementations
{
    public class ForestHunter : IHunter
    {
        public void GoHunt()
        {
           Console.WriteLine("Hi from the forest! I'm hunting here");
        }
    }
}