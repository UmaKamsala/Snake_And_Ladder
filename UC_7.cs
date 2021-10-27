using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder
{
    class UC_7
    {

        private const int IS_LADDER = 0;
        private const int START = 0;
        private const int END = 100;
        private int PlayerOnePosition = 0;
        private int PlayerTwoPosition = 0;
        private bool PlayerOneDone = false;
        private bool PlayerTwoDone = false;
        private bool GameOver = false;
        public Random random = new Random();
        public void Playing()
        {
            Console.WriteLine("Both The Players Starting From Position ZERO");
            int gameStartedBy = random.Next(1, 3);
            switch (gameStartedBy)
            {
                case 1:
                    Console.WriteLine("Player " + gameStartedBy + " started the game");
                    RollDie1();
                    break;
                case 2:
                    Console.WriteLine("Player " + gameStartedBy + " started the game");
                    RollDie2();
                    break;
            }
        }
        public void RollDie1()
        {
            int dieCount1 = 0;
            while (!PlayerOneDone && !PlayerTwoDone)
            {
                dieCount1++;
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                Console.WriteLine("Player 1 Die Value : " + dieNumber);
                int gameCheck = random.Next(0, 2);

                if ((PlayerOnePosition + dieNumber) > 100)
                {
                    Console.WriteLine("Player 1 will stay in same position at " + PlayerOnePosition);
                    PlayerOnePosition -= dieNumber;
                }
                else if ((PlayerOnePosition + dieNumber) == END)
                {
                    PlayerOneDone = (PlayerOnePosition + dieNumber) == END;
                    GameOver = true;
                    Console.WriteLine("Player 1 has reached final position : " + END);
                    Console.WriteLine("Player 1 won the game");
                    break;
                }
                else
                {
                    switch (gameCheck)
                    {
                        case IS_LADDER:
                            if (!PlayerOneDone)
                            {
                                Console.WriteLine("Player 1 Got Ladder ");
                                PlayerOnePosition += dieNumber;
                                Console.WriteLine("Player 1 Ladder Position after rolling " + dieNumber + " is " + PlayerOnePosition);
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("Player 1 Got Snake ");
                            PlayerOnePosition -= dieNumber;
                            if (PlayerOnePosition <= 0)
                            {
                                PlayerOnePosition = START;
                                PlayerOneDone = false;
                            }
                            Console.WriteLine("Player 1 Snake Position after rolling " + dieNumber + " is " + PlayerOnePosition);
                            if (GameOver == false)
                            {
                                Console.WriteLine("Player 2 Turn");
                                RollDie2();
                            }
                            break;
                    }
                }

            }
        }
        public void RollDie2()
        {
            int dieCount2 = 0;
            while (!PlayerTwoDone && !PlayerOneDone)
            {
                dieCount2++;
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                Console.WriteLine("Player 2 Die Value : " + dieNumber);
                int gameCheck = random.Next(0, 2);

                if ((PlayerTwoPosition + dieNumber) > 100)
                {
                    Console.WriteLine("Player 2 will stay in same position at " + PlayerTwoPosition);
                    PlayerTwoPosition -= dieNumber;
                }
                else if ((PlayerTwoPosition + dieNumber) == END)
                {
                    PlayerTwoDone = (PlayerTwoPosition + dieNumber) == END;
                    GameOver = PlayerTwoDone;
                    Console.WriteLine("Player 2 has reached final position : " + END);
                    Console.WriteLine("Player 2 won the game");
                    break;
                }
                else
                {
                    switch (gameCheck)
                    {
                        case IS_LADDER:
                            if (!PlayerTwoDone)
                            {
                                Console.WriteLine("Player 2 Got Ladder ");
                                PlayerTwoPosition += dieNumber;
                                Console.WriteLine("Player 2 Ladder Position after rolling " + dieNumber + " is " + PlayerTwoPosition);
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("Player 2 Got Snake ");
                            PlayerTwoPosition -= dieNumber;
                            if (PlayerTwoPosition <= 0)
                            {
                                PlayerTwoPosition = START;
                                PlayerTwoDone = false;
                            }
                            Console.WriteLine("Player 2 Snake Position after rolling " + dieNumber + " is " + PlayerTwoPosition);
                            if (GameOver == false)
                            {
                                Console.WriteLine("Player 1 Turn");
                                RollDie1();
                            }
                            break;
                    }
                }
            }
        }
    }
}






