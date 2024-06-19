using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Warrior : Hero
    {
        public int Armor { get; private set; }

        public Warrior(string name) : base(name)
        {
            Health = 600;
            Strength = 70;
            Armor = 50;
        }

        public override int Attack()
        {
            int coef = Random.Shared.Next(85, 116);
            return (coef * Strength) / 100;
        }

        public override void TakeDamage(int incomingDamage)
        {
            int reducedDamage = incomingDamage - Armor;
            if (reducedDamage < 0) reducedDamage = 0;
            Health -= reducedDamage;
        }

        public void ShieldBash()
        {
            Armor += 20; 
        }
    }
}
