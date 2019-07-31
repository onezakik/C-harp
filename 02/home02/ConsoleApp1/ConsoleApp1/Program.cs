using System;


namespace homee02 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число первое число");
            string a = Console.ReadLine();
            int i = int.Parse(a);

            Console.WriteLine("Введите число второе число");
            string b = Console.ReadLine();
            int o = int.Parse(b);

           

            Console.WriteLine(i + o);
            Console.WriteLine(i - o);
            Console.WriteLine(i * o);
        }
    }
}