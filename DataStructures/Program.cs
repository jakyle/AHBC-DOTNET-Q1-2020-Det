using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack
            var numberStack = new Stack<int>();

            numberStack.Push(2);
            numberStack.Push(4);
            numberStack.Push(5);


            Console.WriteLine(numberStack.Peek());

            numberStack.Pop();
            var result = numberStack.Pop();

            Console.WriteLine(numberStack.Peek());

            var names = new[] { "James", "Darion", "Alejandra", "Jonathan" };

            var nameStack = new Stack<string>();
            foreach (var name in names)
            {
                nameStack.Push(name);
            }
            Console.WriteLine(nameStack.Peek());

            // Queue
            var orderQueue = new Queue<string>();

            orderQueue.Enqueue("Hamburger");
            orderQueue.Enqueue("Salmon");
            orderQueue.Enqueue("Soda");

            var currentOrder = orderQueue.Dequeue();
            Console.WriteLine(currentOrder);

            Console.WriteLine(orderQueue.Peek());


            // Vector (our OWN list)

            var vector = new Vector<string>();
            vector.Add("James");
            vector.Add("James");
            vector.Add("James");
            vector.Add("James");

            var secondItem = vector.IndexAt(2);
            var seventhItem = vector.IndexAt(7);


            // arrays

            int[] numberArray = new int[4] { 1, 2, 3, 5 };

           // numberArray[5] = 4;  // THIS WILL GIVE YOU AN INDEX OUT OF RANGE EXCEPTION
                
            numberArray = new int[100];

            numberArray[5] = 4;  //  LEGIT
            

        }
    }
}
