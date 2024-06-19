using ArenaGameEngine;

namespace ArenaGameWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddItemToListBoxKnight(string s)
        {
            ListBoxKnight.Items.Add(s);
        }

        public void AddItemToListBoxRogue(string s)
        {
            ListBoxRogue.Items.Add(s);
        }

        public void AddItemToListBoxMage(string message)
        {
            
            listBoxMage.Items.Add(message);
        }

        public void AddItemToListBoxWarrior(string message)
        {
            
            listBoxWarrior.Items.Add(message);
        }

        private void bNewGame_Click(object sender, EventArgs e)
        {

            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Mage mage = new Mage("Gandalf");
            Warrior warrior = new Warrior("Conan");
            Arena arena = new Arena(knight, rogue, mage, warrior);
            arena.EventListener = new WinFormsGameEventListener(this);
            Hero winner = arena.Battle();
            
            MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
        }
    }
}
