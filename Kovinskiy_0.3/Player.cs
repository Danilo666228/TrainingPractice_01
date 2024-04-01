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

        public int SpellPara()
        {
            return Damage = 250;
        }
    }
}