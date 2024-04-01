using System;

namespace Kovinskiy_0._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Введите кол-во у вас золото: ");
            int UserValue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Вы желаете купить 30 кристалов");
            int CrystalPrice = 30;
            
            int remainder = UserValue - CrystalPrice;
            
            bool canBuy = UserValue >= CrystalPrice;

            Console.WriteLine(canBuy ? $"Сделка завершена\nВаш остаток: {remainder}" : "У вас меньше, чем нужно");
        }
    }
}