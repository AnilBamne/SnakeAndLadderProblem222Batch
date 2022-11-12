using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem222Batch
{
    //game played by two players Player1 And Player2
    public class SnakeAndLadder
    {
        public const int WinPosition = 100;
        public static Random random = new Random();
        //Methos for rolling the dice
        public static int ThrowDice()
        {
            return random.Next(1, 7);
        }
        //method for checking option Snake or Ladder
        public static int CheckOption()
        {
            return random.Next(0, 3);
        }
        public static void Main(String[] args)
        {
            int player1Position = 0;
            int player2Position = 0;
            int player1DiceCount = 0;
            int player2DiceCount = 0;

            while(player1Position < WinPosition-1 || player1Position < WinPosition - 1)
            {
                int player1ThrowDie = ThrowDice();
                player1DiceCount++;
                int player2ThrowDie = ThrowDice();
                player2DiceCount++;
                int option = CheckOption();

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Player got No Play");
                        break;
                    case 1:
                        Console.WriteLine("Player got the ladder");
                        player1Position += player1ThrowDie;
                        player2Position += player2ThrowDie;
                        if (player1Position > WinPosition)
                        {
                            player1Position -= player1ThrowDie;
                        }
                        else if (player2Position > WinPosition)
                        {
                            player2Position -= player2ThrowDie;
                        }
                        Console.WriteLine("Player 1 position is = " + player1Position);
                        Console.WriteLine("Player 2 position is = " + player2Position);
                        //Player played one more time in case of ladder
                        Console.WriteLine("Player got the ladder so player gets one more chance");
                        player1Position += player1ThrowDie;
                        player2Position += player2ThrowDie;
                        if (player1Position > WinPosition)
                        {
                            player1Position -= player1ThrowDie;
                        }
                        else if (player2Position > WinPosition)
                        {
                            player2Position -= player2ThrowDie;
                        }
                        Console.WriteLine("Player 1 position is = " + player1Position);
                        Console.WriteLine("Player 2 position is = " + player2Position);
                        break;
                    case 2:
                        Console.WriteLine("Player got the snake");
                        if((player1Position - player1ThrowDie) < 0)
                        {
                            player1Position = 0;
                        }
                        else
                        {
                            player1Position -= player1ThrowDie;
                        }
                        if ((player2Position - player2ThrowDie) < 0)
                        {
                            player2Position = 0;
                        }
                        else
                        {
                            player2Position -= player2ThrowDie;
                        }
                        Console.WriteLine("Player 1 position is = " + player1Position);
                        Console.WriteLine("Player 2 position is = " + player2Position);
                        break;
                    default:
                        break;
                }
                if (player1Position == WinPosition)
                {
                    Console.WriteLine("Player 1 is won!");
                    Console.WriteLine("Number of dice was played by player for win the game is = " + player1DiceCount);
                    break;
                }
                else if ((player2Position == WinPosition) && (player1Position != WinPosition))
                {
                    Console.WriteLine("Player two is won!");
                    Console.WriteLine("Number of dice was played by player for win the game is = " + player2DiceCount);
                    break;
                }
            }
        }
    }
}
