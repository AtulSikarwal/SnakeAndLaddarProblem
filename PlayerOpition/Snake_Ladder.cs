using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblem
{
    internal class Snake_Ladder
    {
        public int Player1 = 0;



        // Ladder : 6 to 46, 19 to 43,52 to 71, 57 to 98
        //Snake :47 to 9, 62 to 40, 96 to 75
        public void SnakeAndLadder()
        {
            Random random = new Random();
            int Dice = random.Next(1, 7);
            Console.WriteLine(Player1);
            Console.WriteLine(Dice);

            int Option = random.Next(0, 3);

            if (Option == 1)
            {
                Player1 += Dice;


                if (Player1 == 6)
                {
                    Console.WriteLine("Player 1 Ladder 6");
                    Player1 += 40;
                    Option = 1;
                }
                else if (Player1 == 19)
                {
                    Console.WriteLine("Player 1 Ladder 19");
                    Player1 += 24;
                    Option = 1;
                }
                else if (Player1 == 52)
                {
                    Console.WriteLine("Player 1 Ladder 52");
                    Player1 += 19;
                    Option = 1;
                }
                else if (Player1 == 57)
                {
                    Console.WriteLine("Player 1 Ladder 57");
                    Player1 += 41;
                    Option = 1;
                }
                //Snake 47 to 9, 62 to 40, 96 to 75
                else if (Player1 == 47)
                {
                    Console.WriteLine("Player 1 Snake 47");
                    Player1 += -38;
                }
                else if (Player1 == 62)
                {
                    Console.WriteLine("Player 1 Snake 62");
                    Player1 += -22;
                }
                else if (Player1 == 96)
                {
                    Console.WriteLine("Player 1 Snake 96");
                    Player1 += -21;
                }
                Console.WriteLine("Player1 " + Player1);
            }

        }
    }
}