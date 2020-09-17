using System;
using Classes.Math;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var wu = new Person();
            wu.FirstName = "Hongyu";
            wu.LastName = "Wu";
            wu.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
