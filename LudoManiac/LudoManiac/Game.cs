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
        //Global stuff
        public int i;

        //Player related
        public string playerName { get; set; }
        public string GameColor;
        public int spillerMaengde;
        public List<string> player = new List<string>();

        //Dice related
       


        //Starts a new game
        public Game()
        {
            WriteLudo("");
            CreatePlayer();
        }

        public void WriteLudo(string txt)
        {
            Console.Clear();
            string textToEnter = "------ LUDO ------";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
        }



        public void CreatePlayer()
        {
            Console.WriteLine("Hvor mange spillere? (1-4):");
            spillerMaengde = Int32.Parse(Console.ReadLine());
            WriteLudo("");

            while (spillerMaengde > 0 && spillerMaengde <= 4)
            {
                for (int i = 1; i <= spillerMaengde; i++)
                {
                    Console.WriteLine("Hvad hedder spiller " + i + "?:");
                    playerName = Console.ReadLine();
                    player.Add(playerName);
                    WriteLudo("");
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