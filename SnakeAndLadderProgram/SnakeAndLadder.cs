using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadder
    {
        //defining a static global variable
        static int diceCount = 0;
        public static void Main(String[] args)
        {
            //game played by two players Player1 And Player2
            Console.WriteLine("This is a two Player snake ladder game.");
            int player1Position = 0;
            int player2Position = 0;
            Console.WriteLine("Player 1 position is: " + player1Position);
            Console.WriteLine("Player 2 position is: " + player2Position);
            //playing both players one by one
            while (player1Position != 100 && player2Position != 100)
            {
                //player1 playing
                Console.Write("Player 1 rolls. ");
                player1Position += PlayerRoll(player1Position);
                if (player1Position < 0)
                {
                    player1Position = 0;
                }
                Console.WriteLine("Player 1 position is: " + player1Position);
                if (player1Position == 100)
                {
                    Console.WriteLine("Player 1 win the game.");
                    break;
                }
                //player2 playing
                Console.Write("Player 2 roll. ");
                player2Position += PlayerRoll(player2Position);
                if (player2Position < 0)
                {
                    player2Position = 0;
                }
                Console.WriteLine("Player 2 position is: " + player2Position);
                if (player2Position == 100)
                {
                    Console.WriteLine("Player 2 win the game.");
                    break;
                }
            }
            Console.WriteLine("Dice rolled for winning : {0}", diceCount);  //num of dice played for winning
        }

        public static int PlayerRoll(int playerPosition)
        {
            //variables
            int position = 0;
            int playTimes = 1;
            //constants
            const int Noplay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random random = new Random();
            while (playTimes != 0)
            {
            gotladder:
                int roll = random.Next(1, 7);
                int option = random.Next(0, 3);
                diceCount++;
                switch (option)
                {
                    //ladder
                    case Ladder:
                        if (playerPosition + position > 100)
                        {
                            Console.WriteLine("Player choose not to play. ");
                            playTimes--;
                        }
                        else
                        {
                            position += roll;
                            Console.WriteLine("Player got the ladder with {0} roll. ", roll, "got a chance to play again");
                            playTimes = 1;
                            if (position < 100)
                            {
                                goto gotladder;
                            }
                        }
                        break;
                    //snake
                    case Snake:
                        position -= roll;
                        Console.WriteLine("Player got the snake with {0} roll. ", roll);
                        playTimes--;
                        break;
                    case Noplay:
                        //no play
                        Console.WriteLine("Player choose not to play. ");
                        playTimes--;
                        break;
                    default:
                        break;
                }

            }
            return position;
        }
    }

}
