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
        public GameState state;

        //Player related
        public string playerName { get; set; }
        public GameState InPlay { get; set; }

        public string GameColor;
        public int spillerMaengde;
        public List<string> player = new List<string>();
        public int Turns;

        //Dice related
        private Random rng = new Random();
        private int diceValue;
        

        //Starts a new game
        public Game()
        {
            WriteLudo("");
            CreatePlayer();
            PlayerTurn();
            Dice();
            ThrowDice();
        }

        public void WriteLudo(string txt)
        {
            this.state = GameState.InPlay;
            Console.Clear();
            Console.WriteLine(Turns);
            string textToEnter = "------ LUDO ------";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
        }

        public int Dice()
        {
            this.diceValue = this.rng.Next(1, 7);
            return this.diceValue;
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

        public int PlayerTurn()
        {
            Turns = 1;
            switch (Turns)
            {
                case 1:
                    Console.WriteLine("It is player " + player[0] + "'s turn");
                    break;
                case 2:
                    Console.WriteLine("It is player " + player[1] + "'s turn");
                    break;
                case 3:
                    Console.WriteLine("It is player " + player[2] + "'s turn");
                    break;
                case 4:
                    Console.WriteLine("It is player " + player[3] + "'s turn");
                    break;
            }
            return 1;
        }

        public int ThrowDice()
        {
            return 1;
        }


    }
}