using System;

namespace ArraysStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            string firstName = "Hongyu";
            String lastName = "Wu";
            var fullName = firstName + " " + lastName;
            //var myFullName = string.Format("My name is {0) {1}", firstName, lastName);

            var names = new string[3] { "Jack", "John", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"hi guys
                        Look into the following paths
                        c:\folder1\folder2
                        c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
