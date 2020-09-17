using System;

namespace VariablesConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 2;
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            // variables
            Console.WriteLine(num);
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // format 
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // const
            const float Pi = 3.14f; // cannot be changed


        }
    }
}
