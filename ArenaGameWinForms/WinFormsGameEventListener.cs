using ArenaGameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWinForms
{
    internal class WinFormsGameEventListener : GameEventListener
    {
        MainForm mainForm;

        public WinFormsGameEventListener(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacks for {attack}.";
            if (attacker is Knight)
            {
                mainForm.AddItemToListBoxKnight(message);
            }
            else if (attacker is Rogue)
            {
                mainForm.AddItemToListBoxRogue(message);
            }
            else if (attacker is Mage)
            {
                mainForm.AddItemToListBoxMage(message);
            }
            else if (attacker is Warrior)
            {
                mainForm.AddItemToListBoxWarrior(message);
            }
        }
    }
}
