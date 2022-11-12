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
            //uc4,uc5 : ensure player gets exact 100 position
            int FinalPosition = 100;
            Random random = new Random();
            //uc2 : Player rolls a die to get between 1-6

            int die = random.Next(1, 7);
            Console.WriteLine("Die rolled for : " + die);
            Position += die;
            while (Position <= FinalPosition)
            {
                  die = random.Next(1, 7);
                  Console.WriteLine("Die rolled for : " + die);
                  Position += die;
                  if (Position > FinalPosition)
                  {
                     Position = Position - die;
                  }
                  Console.WriteLine("Player position is : " + Position);
                  //uc3 : Player checks for option LADDER or SNAKE
                  int option = random.Next(0, 3);
                  switch (option)
                  {
                        case 2:
                            Console.WriteLine("Player got Ladder Next position : {0}+{1}", Position, die);
                            Position += die;
                            if (Position > FinalPosition)
                            {
                                Position = Position - die;
                            }
                        break;
                        case 1:
                            Console.WriteLine("Player got Snake Next position : {0}-{1}", Position, die);
                            Position -= die;
                            break;

                        default:
                            Console.WriteLine("No Play");
                            break;
                  }
                //UC4 , UC5 : get exact 100 position
                if(Position == FinalPosition)
                {
                    Console.WriteLine("Player position is : " + Position);
                    break;
                }
                if (Position < 0)
                {
                    Position = 0;
                }
            }
            Console.WriteLine("Players Final  position is : "+ Position);
        }
    }
}
