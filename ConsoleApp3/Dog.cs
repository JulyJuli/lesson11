using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class Dog
    {
        private readonly IHunter _hunter;
        private readonly ITail _tail;

        public Dog(IHunter hunter, ITail tail)
        {
            _hunter = hunter;
            _tail = tail;
        }

        public void Geeting()
        {
            Console.WriteLine("I am dog");
            _hunter.GoHunt();
            _tail.BiteTail();
        }
    }
}