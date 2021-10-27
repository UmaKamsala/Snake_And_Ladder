using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder
{
    class UC_6
    {
        public const int IS_LADDER = 0;
        public const int IS_SNAKE = 1;
        public const int START = 0;
        public const int END = 100;

        public void DieCount()
        {
            int dieCount = 0;
            int playerPosition = START;

            while (playerPosition <= END)
            {
                dieCount++;
                Random random = new Random();
                int rollCheck = random.Next(1, 7);
                Console.WriteLine("Number got on Roll # " + dieCount + " is : " + rollCheck);
                int gameCheck = random.Next(0, 2);
                if ((playerPosition + rollCheck) > 100)
                {
                    playerPosition -= rollCheck;
                }
                else if ((playerPosition + rollCheck) == 100)
                {
                    int FinalPosition = playerPosition + rollCheck;
                    Console.WriteLine("Player has reached final position : " + FinalPosition);
                    Console.WriteLine("Player won the game");
                    break;
                }
                    switch (gameCheck)
                    {
                        case IS_LADDER:

                            playerPosition += rollCheck;
                            Console.WriteLine("Got Ladder");
                            Console.WriteLine("Player Ladder Position is: " + playerPosition);
                            break;
                        case IS_SNAKE:
                            playerPosition -= rollCheck;
                            Console.WriteLine("Got Snake");
                            Console.WriteLine("Player Snake Position is: " + playerPosition);
                            if (playerPosition < 0)
                            {
                                playerPosition = START;
                                Console.WriteLine("Player Start Position is: " + playerPosition);
                            }
                            break;
                        default:
                            Console.WriteLine("No Play");
                            Console.WriteLine("I will stay in same position");
                            break;
                    }
                }
                Console.WriteLine("Number of times die rolled to reach final position is: " + dieCount);
            }
        }
    }