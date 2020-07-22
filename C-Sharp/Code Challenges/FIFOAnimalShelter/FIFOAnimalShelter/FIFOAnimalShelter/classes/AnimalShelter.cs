using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace FIFOAnimalShelter.classes
{
    public class AnimalShelter<Animal>
    {
        public StacksAndQueues.Queue<Animal> shelter { get; set; } = new StacksAndQueues.Queue<Animal>();
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        /// <summary>
        /// Adds an Animal to the Rear of the shelter queue.
        /// </summary>
        /// <param name="animal">The animal added to the shelter.</param>
        public void Enqueue(Animal animal)
        {
            if (animal.GetType() == typeof(Dog) || animal.GetType() == typeof(Cat)) {
                shelter.Enqueue(animal);
                if (shelter.Rear != null)
                {
                    Rear = shelter.Rear.Value;
                    Front = shelter.Front.Value;
                }
                else
                    Rear = default(Animal);
            }
        }

        /// <summary>
        /// Removes an Animal from the Front of the shelter queue.
        /// </summary>
        /// <param name="pref">If preference is cat or dog, then the queue returns a cat or dog. If not, then it returns null.</param>
        /// <returns>Animal from the Front of the shelter queue</returns>
        public Animal Dequeue(string pref)
        {
            if (pref.ToLower() == "cat" || pref.ToLower() == "dog")
            {
                var animal = shelter.Dequeue();
                if (shelter.Front != null)
                    Front = shelter.Front.Value;
                else
                {
                    Front = default(Animal);
                    Rear = default(Animal);
                }
                return animal;

            }
            return default(Animal);
        }
    }
}
