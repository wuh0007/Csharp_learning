using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            // Array
            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Clear method: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Copy method: ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Sort method: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Reverse method: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Lists
            var newNumbers = new List<int>() { 1, 2, 3, 4 };
            newNumbers.Add(1);
            newNumbers.AddRange(new int[3] { 5, 6, 7 });
            Console.WriteLine("List: ");
            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }
            // IndexOf()
            var newIndex = newNumbers.IndexOf(1);
            var newIndexTwo = newNumbers.LastIndexOf(1);
            Console.WriteLine("Index List: " + newIndex);
            Console.WriteLine("IndexLast List: " + newIndexTwo);
            Console.WriteLine("Count List: " + newNumbers.Count);
            newNumbers.Remove(1);
            Console.WriteLine("List Remove: ");
            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }

            newNumbers.Clear();

        }
    }
}
