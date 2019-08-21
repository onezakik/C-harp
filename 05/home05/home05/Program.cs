using System;

namespace home05
{
    class Program
    {
        public enum  figures
        { circle=1,
            triangle=2,
            rectangle=3,
        }
        public static void Main()
        //static void Main(string[] args)
        {
            Console.WriteLine("ВВедите тип фигуры ");
            string num =Console.ReadLine();
            switch (num)
            {
                case "1":
                    Console.WriteLine("Ведите диаметр");
                    int numa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Пириметр={0}", Math.PI * numa);
                    Console.WriteLine("Ведите радиус");
                    int Rad = int.Parse(Console.ReadLine());
                    Console.WriteLine("S={0}", Math.PI * Rad * Rad);
                    break;
                case "2":
                    Console.WriteLine("Введите сторону");
                    int sss = int.Parse(Console.ReadLine());
                    Console.WriteLine("P={0}", sss + sss + sss);
                    break;
                case "3":
                    Console.WriteLine("Введите высоту");
                    int aaa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите широту");
                    int bbb = int.Parse(Console.ReadLine());
                    Console.WriteLine("P={0}",(aaa+bbb)*2 );
                    Console.WriteLine("S={0}", aaa * bbb);
                    break;
                               
            }
             Console.ReadKey();




        }
    }
}
