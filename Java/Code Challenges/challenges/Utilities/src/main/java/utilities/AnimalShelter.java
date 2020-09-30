package utilities;

public class AnimalShelter {
    private Queue<Animal> animals = new Queue();

    public void enqueue(Animal animal) {
        animals.enqueue(animal);
    }

    public Animal dequeue(String preference) {
        String normalized = preference.toUpperCase();
        if (normalized.equals("DOG"))
            return getDog();
        else if (normalized.equals("CAT"))
            return getCat();
        else
            return null;
    }

    private Animal getDog() {
        Animal target = null;
        Queue<Animal> temp = new Queue();
        while (!animals.isEmpty()) {
            if (animals.peek().getClass().equals(Dog.class) && target == null)
                target = animals.dequeue();
            else
                temp.enqueue(animals.dequeue());
        }
        while (!temp.isEmpty()) {
            animals.enqueue(temp.dequeue());
        }
        return target;
    }

    private Animal getCat() {
        Animal target = null;
        Queue<Animal> temp = new Queue();
        while (!animals.isEmpty()) {
            if (animals.peek().getClass().equals(Cat.class) && target == null)
                target = animals.dequeue();
            else
                temp.enqueue(animals.dequeue());
        }
        while (!temp.isEmpty()) {
            animals.enqueue(temp.dequeue());
        }
        return target;
    }
}
