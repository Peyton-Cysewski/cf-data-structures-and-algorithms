using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.classes
{
    public class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }
    }
}
