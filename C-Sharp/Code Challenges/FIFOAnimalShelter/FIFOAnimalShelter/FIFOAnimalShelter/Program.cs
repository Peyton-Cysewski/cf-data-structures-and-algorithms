using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = default(Animal);
            if (thing == null)
                Console.WriteLine($"null");
        }
    }
}
