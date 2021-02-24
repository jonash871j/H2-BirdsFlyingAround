using BirdsFlyingAround.Birds;
using System;
using System.Collections.Generic;

namespace BirdsFlyingAround
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>()
            {
                new Duck(32, 0, 128),
                new Ostrich(64, 0),
                new Pigeon(70, 0, 64),
                new Pingvin(16, 0),
                new Seagull(24, 0, 32),
            };

            foreach (Bird bird in birds)
            {
                Console.WriteLine($"I'm a {bird.GetType().Name} which is a bird!");

                if (bird is IFly)
                {
                    Console.WriteLine("I can fly and move!");
                }
                else
                {
                    Console.WriteLine("I can only move!");
                }
            }
        }
    }
}
