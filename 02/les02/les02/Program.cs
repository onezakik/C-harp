using System;

namespace les02
{
    class Program
    {
        static void Main()
        {
            int a; // declaring a variable
            a = 10; // setting a value

            int b = 20;
            string name = "Ai";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(name);

            Console.WriteLine($"{a} * {b} = { a* b}");

            var newA = 10;
            var newB = "Ai";


           

            int sun = 1_321_123;

            long universe = sun;

            sun = (int)universe;

            float f = sun;

            sun =(int)f;

            string valueOfSun = sun.ToString();


            Console.WriteLine(valueOfSun);
            Console.WriteLine(sun);

            Console.WriteLine("Введите число:");
            string value = Console.ReadLine();
            int integerValue = int.Parse(value);

            Console.WriteLine(value + value);
            Console.WriteLine(integerValue + integerValue);

            var s = 175;
            var ss = 175 == 0;



        }
    }
}
