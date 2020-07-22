using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.classes
{
    public class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }
    }
}
