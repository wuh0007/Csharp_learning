using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int m = 1;
            byte n = (byte)m;
            Console.WriteLine(n);

            var num = "1234";
            int k = Convert.ToInt32(num);
            Console.WriteLine(k);


            try
            {
                var number = "1234";
                int j = Convert.ToByte(number);
                Console.WriteLine(j);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
