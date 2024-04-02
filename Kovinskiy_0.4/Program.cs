using System;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Kovinskiy_0._4
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;

            char[,] map = ReadMap("map.txt");
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            Task.Run(() =>
            {
                while (true)
                {
                    pressedKey = Console.ReadKey();
                }
            });

            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;
            int totalFoodCount = CountTotalFood(map);
            bool isOpen = true;
            
            while (isOpen)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.Write("@");
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(40, 0);
                Console.Write($"Score : {score}");

                DrawFoodBar(score, totalFoodCount);

                HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);

                
                Thread.Sleep(70);
            }

            
        }

        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map,
            ref int score)
        {
            int[] direction = GetDirection(pressedKey);

            int nextPacmanPositionX = pacmanX + direction[0];
            int nextPacmanPositionY = pacmanY + direction[1];

            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if (nextCell == ' ' || nextCell == '*')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;

                if (nextCell == '*')
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
                }
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        {
            int[] direction = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                direction[1] -= 1;
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                direction[1] += 1;
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                direction[0] -= 1;
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                direction[0] += 1;
            }
            return direction;
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines(path);
            char[,] map = new char[GetMaxLengthOfLine(file), file.Length];

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = file[y][x];
                }
            }
            return map;
        }
        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }

                Console.Write("\n");
            }
        }
        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }

        private static int CountTotalFood(char[,] map)
        {
            int count = 0;

            foreach (char cell in map)
            {
                if (cell == '*')
                {
                    count++;
                }
            }
            return count;
        }
        private static void DrawFoodBar(int currentScore, int totalFoodCount)
        {
            Console.SetCursorPosition(40, 1);
            Console.Write("[");

            int progress = currentScore * 10 / totalFoodCount;

            for (int i = 0; i < 10; i++)
            {
                if (i < progress)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("_");
                }
            }

            Console.Write("]");
        }
    }
}