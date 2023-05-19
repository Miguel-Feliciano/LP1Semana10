using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            Stack<string> stringStack = new Stack<string>();
            Queue<string> stringQueue = new Queue<string>();
            HashSet<string> stringHashSet = new HashSet<string>();

            // Inserts the same five strings into each collection, two of which are equal
            string[] strings = { "Star Wars", "The Legend of Zelda", "One Piece", "Overwatch", "FullMetal Alchemist" };
            foreach (string str in strings)
            {
                stringList.Add(str);
                stringStack.Push(str);
                stringQueue.Enqueue(str);
                stringHashSet.Add(str);
            }

            Console.WriteLine("Elements in List<T>:");
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nElements in Stack<T>:");
            foreach (string str in stringStack)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nElements in Queue<T>:");
            foreach (string str in stringQueue)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nElements in HashSet<T>:");
            foreach (string str in stringHashSet)
            {
                Console.WriteLine(str);
            }
        }
    }
}
