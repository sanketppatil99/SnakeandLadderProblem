using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class SnakeLadderOption
    {     
        public static void CheckforOption()
        {
            int PlayerPosition = 0;
           
            Random random = new Random();
            int Dicecount = random.Next(1, 7);
            int choice = random.Next(0, 4);
            switch (choice)
            {

                case 1:
                    PlayerPosition += 0;
                    Console.WriteLine("player is at same place");
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    PlayerPosition += Dicecount;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                case 3:
                    Console.WriteLine("Snake");
                    PlayerPosition -= Dicecount;
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                default:
                    Console.WriteLine("invalid data");
                    break;
            }
        }
    }
}
