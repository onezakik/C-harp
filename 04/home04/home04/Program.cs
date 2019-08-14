using System;


namespace home04
{
    class Program
    {
        [Flags]
        enum Colorsw
        {

            Black = 0x1,
            Blue = 0x1 << 1,
            Cyan = 0x1 << 2,
            Grey = 0x1 << 3,
            Green = 0x1 << 4,
            Magenta = 0x1 << 5,
            Red = 0x1 << 6,
            White = 0x1 << 7,
            Yellow = 0x1 << 8,

        }



        static void Main(string[] args)
        {
            Colorsw allColors = 0;
            foreach (Colorsw Color in Enum.GetValues(typeof(Colorsw)))
            {
                allColors |= Color;
            }

            Console.WriteLine("Список цветов");
            Console.WriteLine(allColors);

            Colorsw favoriteColors = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите любимый цвет {i + 1}:");
                object color = Enum.Parse(typeof(Colorsw), Console.ReadLine());
                favoriteColors |= (Colorsw)color;
            }

            Console.WriteLine("любимый цвет");
            Console.WriteLine(favoriteColors);
            Console.WriteLine();


            Colorsw notFavoriteColors = allColors ^ favoriteColors;

            Console.WriteLine("не любимые цвета:");
            Console.WriteLine(notFavoriteColors);
            Console.WriteLine();

            Console.WriteLine("\nOтлфдочная информация:");
            WriteInt32ValueWithBits(allColors,nameof(allColors));
            WriteInt32ValueWithBits(favoriteColors,nameof(favoriteColors));
            WriteInt32ValueWithBits(notFavoriteColors,nameof(notFavoriteColors));
        }

        static void WriteInt32ValueWithBits(object value, string description)
        {
            Console.WriteLine(
                "Flags: {0} : {1}",
                Convert.ToString((int)value, 2).PadLeft(32, '0'),
                description);
        }

    
    }
}


