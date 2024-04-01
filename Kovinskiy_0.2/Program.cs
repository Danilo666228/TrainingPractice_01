using System;

namespace Kovinskiy_0._2
{
    internal class Program
    {
        static void GameField(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Не чётные цифры в координате белый\nЧетный цифры в координате черный");
            string[,] array = new string[,]
            {
                { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8" },
                { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8" },
                { "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8" },
                { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8" },
                { "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8" },
                { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8" },
                { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8" },
                { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8" },
            };
            GameField(array);
            
            Console.WriteLine("Введите первую координату");
            string CoordinateOne = Console.ReadLine();

            Console.WriteLine("Введите вторую координату");
            string CoordinateTwo = Console.ReadLine();

            bool isSameColor = IsColor(CoordinateOne, CoordinateTwo);

            if (isSameColor)
            {
                Console.WriteLine("Выбранные координаты одного цвета. Успех!");
            }
            else
            {
                Console.WriteLine("Выбранные координаты разного цвета. Ошибка!");
            }
        }
        static bool IsColor(string cord1, string cord2)
        {
            int coord1Num = (cord1[1]) % 2; 
            int coord2Num = (cord2[1]) % 2;
            
            return (coord1Num) % 2 == (coord2Num) % 2;
        }
    }
}