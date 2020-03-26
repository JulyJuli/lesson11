using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class CatDog
    {
        private readonly IHunter _hunter;
        private readonly ITail _tail;
        private readonly IValerian _valerian;

        public CatDog(IHunter hunter, ITail tail, IValerian valerian)
        {
            _hunter = hunter;
            _tail = tail;
            _valerian = valerian;
        }

        public void Geeting()
        {
            Console.WriteLine("I am dog");
            _hunter.GoHunt();
            _tail.BiteTail();
            _valerian.GoNutsOverValerian();
        }
    }
}