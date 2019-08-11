using System;

namespace home03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 11;
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < num; j++)
                {
                    Console.Write("{0} ", i * j);
                }
            }
            Console.ReadKey();

        }
    }
}
