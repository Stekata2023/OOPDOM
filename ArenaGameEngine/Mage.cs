using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Mage : Hero
    {
        public int Mana { get; private set; }

        public Mage(string name) : base(name)
        {
            Health = 400;
            Strength = 50;
            Mana = 200;
        }

        public override int Attack()
        {
            int coef = Random.Shared.Next(90, 131);
            int damage = (coef * Strength) / 100;
            if (Mana >= 50)
            {
                Mana -= 50;
                damage += 30; 
            }
            return damage;
        }

        public void CastSpell()
        {
            if (Mana >= 100)
            {
                Mana -= 100;
                Health += 50; 
            }
        }

        public override void TakeDamage(int incomingDamage)
        {
            Health -= incomingDamage;
            if (Mana < 200)
            {
                Mana += 20; 
            }
        }
    }
}
