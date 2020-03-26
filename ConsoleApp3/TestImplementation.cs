using System;

namespace ConsoleApp3
{
    public class TestImplementation : ITestInterface
    {
        public void Print()
        {
            Console.WriteLine("Hi here!");
        }
    }
}