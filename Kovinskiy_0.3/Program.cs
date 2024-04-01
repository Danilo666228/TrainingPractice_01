using System;

namespace Kovinskiy_0._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать на битву с боссом");
            Player player1 = new Player("Danya", 500, 100);

            Enemy enemy1 = new Enemy("Vova", 1000, 50);

            bool isOpen = true;


            while (isOpen)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Ход игрока:");
                Console.WriteLine("1 - Обычная атака\n2 - Pups\n3 - TeleMort\n4 - Jumshak\n 5 - GoogShot");
                switch (Console.ReadLine())
                {
                    case "1":
                        enemy1.Health -= player1.DefaultAttack();
                        IsWin();
                        Console.WriteLine($"Здоровье босса: {enemy1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "2":
                        enemy1.Health -= player1.Pupse();
                        IsWin();
                        Console.WriteLine($"Здоровье босса: {enemy1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "3":
                        player1.Health += player1.Telemort();
                        IsWin();
                        Console.WriteLine($"Вы восстоновили себе 250 здоровья, Ваша хп:  {player1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "4":
                        enemy1.Health -= player1.Jumshak();
                        IsWin();
                        Console.WriteLine($"Здоровье босса: {enemy1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "5":
                        enemy1.Health -= player1.GoogShot();
                        IsWin();
                        Console.WriteLine($"Здоровье босса: {enemy1.Health}");
                        Console.WriteLine("--------------");
                        break;
                }

                Console.WriteLine("Ход босса");
                Console.WriteLine("1 - Обычная атака\n2 - Pups\n3 - TeleMort\n4 - Jumshak\n 5 - GoogShot");

                switch (Console.ReadLine())
                {
                    case "1":
                        player1.Health -= enemy1.DefaultAttack();
                        IsWin();
                        Console.WriteLine($"Здоровье игрока: {player1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "2":
                        player1.Health -= enemy1.Pupse();
                        IsWin();
                        Console.WriteLine($"Здоровье игрока: {player1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "3":
                        enemy1.Health += enemy1.Telemort();
                        IsWin();
                        Console.WriteLine($"Вы восстоновили себе 250 здоровья, Ваша хп:  {enemy1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "4":
                        player1.Health -= enemy1.Jumshak();
                        IsWin();
                        Console.WriteLine($"Здоровье игрока: {player1.Health}");
                        Console.WriteLine("--------------");
                        break;
                    case "5":
                        player1.Health -= enemy1.GoogShot();
                        IsWin();
                        Console.WriteLine($"Здоровье игрока: {player1.Health}");
                        Console.WriteLine("--------------");
                        break;
                }
            }

            void IsWin()
            {
                if (player1.Health <= 0)
                {
                    Console.WriteLine("Игрок умер");
                    isOpen = false;
                }

                if (enemy1.Health <= 0)
                {
                    Console.WriteLine("Босс умер");
                    isOpen = false;
                }
            }
        }
    }
}