using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        // fields
        public int x;
        public int y;
        public int health;
        public int shield;
        public int lives;
        public string name;

        // methods
        public Player(string name, int health) // constructor
        {
            // instantiation
            // -------------
            x = 0;
            y = 0;
            this.health = health;
            this.name = name;

            Console.WriteLine(name + " Player class constructed...");
        }

        public void TakeDamage(int hp)
        {
            Console.WriteLine(name + " has taken " + hp + " damage...");
            health -= hp;
        }

        public void ShowStats()
        {
            Console.WriteLine(name + " health = " + health);
        }
    }
}
