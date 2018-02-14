using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoManiac
{
    //Ludo colors
    public enum GameColor { Gul, Blå, Rød, Grøn };
    public enum GameState { InPlay, Finished };

    public class Game
    {
        public string playerName { get; set; }
        public string GameColor;
        public int spillerMaengde;
        public int i;
        public string playerOne;
        public string name;

        private Dice dice = new Dice();
        //private Player hejsa = new Player();
        
        //Starts a new game
        public Game()
        {
            CreatePlayer();

        }

        public void CreatePlayer()
        {

            List<string> player = new List<string>();
            Console.WriteLine("Hvor mange spillere? (1-4):");
            spillerMaengde = Int32.Parse(Console.ReadLine());

            while (spillerMaengde > 0 && spillerMaengde <= 4)
            {
                for (int i = 1; i <= spillerMaengde; i++)
                {
                    Console.WriteLine("Hvad hedder spiller " + i + "?:");
                    playerName = Console.ReadLine();
                    player.Add(playerName);
                    //Console.ReadLine();
                }

                switch (spillerMaengde)
                {
                    case 1:
                        Console.WriteLine("Spiller 1's navn er: " + player[0]);
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Spiller 1's navn er: " + player[0]);
                        Console.WriteLine("Spiller 2's navn er: " + player[1]);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Spiller 1's navn er: " + player[0]);
                        Console.WriteLine("Spiller 2's navn er: " + player[1]);
                        Console.WriteLine("Spiller 3's navn er: " + player[2]);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Spiller 1's navn er: " + player[0]);
                        Console.WriteLine("Spiller 2's navn er: " + player[1]);
                        Console.WriteLine("Spiller 3's navn er: " + player[2]);
                        Console.WriteLine("Spiller 4's navn er: " + player[3]);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Too many players! Pick a number from 1-4");
                        spillerMaengde = Int32.Parse(Console.ReadLine());
                        break;
                }
                break;
            }
        }
    }
}

