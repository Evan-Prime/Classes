using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        struct Vector2
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Classes:");
            Console.WriteLine("--------");
            Console.WriteLine("");

            // fundamental information data
            // ----
            // single pieces of data
            // ---------------------
            int lives; // declaration
                       // No instantiation... why???
            lives = 3; // instantiation
            // int lives = 3; // short hand

            // stuct
            // -----
            Vector2 position; // declaration
                              // No instantiation... why???
            position.x = 10; // instantiation
            position.y = 10; // instantiation

            // arrays
            // ------
            // multiple pieces of the same data
            // --------------------------------
            int[] ammo; // declaration
            ammo = new int[3]; // instantiation... what is this???
            ammo[0] = 50; // instantiation
            ammo[1] = 15; // instantiation
            ammo[2] = 5; // instantiation
            // int[] ammo = new int[5]; // short hand

            // classes
            // -------
            // multiple pieces of data
            // -----------------------
            Player player1; // declaration
            Player player2; // declaration
            //player.health = 100; // DOES NOT WORK
            player1 = new Player("EvanSeven2003", 100); // instantiation
            player2 = new Player("FalseBaconator", 100); // instantiation
            player1.ShowStats();
            player2.ShowStats();
            player1.TakeDamage(15);
            player2.TakeDamage(75);
            player1.ShowStats();
            player2.ShowStats();
            // Player player = new Player(); // short hand

            Enemy enemySmall = new Enemy();
            Enemy enemyMedium = new Enemy();
            Enemy enemyLarge = new Enemy();


            Console.WriteLine("");
            Console.WriteLine("Press any button to exit!");
            Console.ReadKey(true);
        }
    }
}
