using System;

namespace CL05
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Введите выход");

            //do
            //{
            //    string aaa = Console.ReadLine();

            //    if (aaa == "выход")
            //        break;

            //    if (aaa.Length <= 15)
            //    {
            //        Console.WriteLine("Длина строки {0}", aaa.Length);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Много символов");
            //        continue;
            //    }

            //} while (true);

            //Console.ReadKey();




            //Console.WriteLine("любые 5 чисел");
            //int sun = 0;
            //int num = 0;

            //while (num < 5)
            //{
            //    int a;
            //    try
            //    {
            //        a = int.Parse(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Это не число");
            //        continue;
            //    }
            //    sun += a;

            //    num++;
            //    }
            //Console.WriteLine("Сумма {0}",sun);
            //Console.ReadKey();


            int[][] marks = new[]
            {
                new [] {2,3,3,2,3},
                new [] {2,3,4,3},
                null,
                new [] {5,5,5,5 },
                new [] {4 }
            };
            double avrDay = 0;
            double avrWeek = 0;
            double strDay = 0;
            double strWeek = 0;
            int Count = 0;

            for (int a = 0; a < marks.Length; a++)
            {
                if (marks[a] != null)
                {
                    for (int i = 0; i < marks[a].Length; i++)
                    {
                        Count += 1;
                        strDay = (strDay + marks[a][i]);
                    }
                    avrDay = strDay / marks[a].Length;
                    Console.WriteLine("За день {0}: Средний балл {1}", a, avrDay);
                    
                    strWeek = (strWeek + strDay);
                    strDay = 0;

                }
            }
            
            avrWeek = strWeek / marks.Length;
            Console.WriteLine("За неделю Средний балл {0}", avrWeek);
            Console.ReadKey();

        }
    }
}

