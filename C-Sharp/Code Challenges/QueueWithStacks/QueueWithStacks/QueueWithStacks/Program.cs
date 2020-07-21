using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFakeQueue();
        }

        static void RunFakeQueue()
        {
            PseudoQueue fake = new PseudoQueue();
            fake.Enqueue(1);
            fake.Enqueue(2);
            fake.Enqueue(3);
            fake.Enqueue(4);
            fake.Enqueue(5);
            int[] emptied = new int[5];
            for (int i = 0; i < 5; i++)
            {
                emptied[i] = fake.Dequeue();
            }
            foreach (int num in emptied)
            {
                Console.WriteLine($"{num}");
            }
        }
    }
}
