using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem222Batch
{
    public class SnakeAndLadder
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Program");
            //uc1 : Game played by single player
            int Position = 0;
            Random random = new Random();
            //uc2 : Player rolls a die to get between 1-6
            
            int die=random.Next(1,7);
            Position += die;
            Console.WriteLine("Player position is : "+Position);
        }
    }
}
