using System;

namespace Kovinskiy_0._3
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public int DefaultAttack()
        {
            return Damage = 50;
        }

        public int Pupse()
        {
            Console.WriteLine("Вы используете свой посох веры,\nБьёте о земпю тем самым происхоидт импульс и враг получает 250 урона");
            return Damage = 250;
        }

        public int Telemort()
        {
            Console.WriteLine("Вы используете телепорт чтобы телепортироваться в другое измерение и пополняете себе 250 здоровья");
            return Health = 300;
        }

        public int Jumshak()
        {
            Console.WriteLine("Вы используете прыжок веры и с огромной силой приземляетесь на врага нанося ему 75 урона");
            return Damage = 75;
        }

        public int GoogShot()
        {
            Console.WriteLine("Вы используете всю свою энергию и очень быстро атакуете врага");
            return Damage = 500;
        }
    }
}