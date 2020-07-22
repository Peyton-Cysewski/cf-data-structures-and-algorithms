using FIFOAnimalShelter;
using FIFOAnimalShelter.classes;
using System;
using Xunit;
using StacksAndQueues;

namespace ShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueWorks()
        {
            // Assign
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();
            Dog champ = new Dog("Champ");
            // Act
            shelter.Enqueue(champ);
            string expected = "Champ";
            string actual = shelter.Front.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DequeueWorks()
        {
            // Assign
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();
            Cat cat = new Cat("Kitty");
            // Act
            shelter.Enqueue(cat);
            var kitty = shelter.Dequeue("cat");
            string expected = "Kitty";
            string actual = kitty.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanEnqueueMultipleAnimals()
        {
            // Assign
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();
            Dog champ = new Dog("Champ");
            Cat kitty = new Cat("Kitty");
            Dog bud = new Dog("Bud");
            // Act
            shelter.Enqueue(champ);
            shelter.Enqueue(kitty);
            shelter.Enqueue(bud);
            string expected = "Champ";
            string actual = shelter.Front.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanDequeueMultipleAnimals()
        {
            // Assign
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();
            Dog champ = new Dog("Champ");
            Cat kitty = new Cat("Kitty");
            Dog bud = new Dog("Bud");
            // Act
            shelter.Enqueue(champ);
            shelter.Enqueue(kitty);
            shelter.Enqueue(bud);
            shelter.Dequeue("Dog");
            var animal = shelter.Dequeue("Cat");
            string expected = "Kitty";
            string actual = animal.Name;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DequeueReturnsNull()
        {
            // Assign
            AnimalShelter<Animal> shelter = new AnimalShelter<Animal>();
            Cat cat = new Cat("Kitty");
            // Act
            shelter.Enqueue(cat);
            var animal = shelter.Dequeue("Lizard");
            Animal expected = null;
            Animal actual = animal;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
