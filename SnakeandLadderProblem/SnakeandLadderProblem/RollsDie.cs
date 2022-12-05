using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class RollsDie
    {
        public static void rollsDie()
        {
            Random random = new Random();
            int x = random.Next(1, 7);
            Console.WriteLine("Player Rolls Die Number is :" + x);


        }
    }
}
