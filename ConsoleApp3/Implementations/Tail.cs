using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Implementations
{
    public class Tail : ITail
    {
        public void BiteTail()
        {
            Console.WriteLine("I like to bite my tail");
        }
    }
}