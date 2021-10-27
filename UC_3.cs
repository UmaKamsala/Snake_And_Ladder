using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder
{
    class UC_3
    {
        public const int IS_LADDER = 0;
        public const int IS_SNAKE = 1;
        public const int START = 0;
        public Random random = new Random();
        public void Play()
        {
            int playerPosition = START;
            int rollCheck = random.Next(1, 7);
            Console.WriteLine("Number got on Die: " + rollCheck);
            int gameCheck = random.Next(0, 3);

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
                    break;
                default:
                    Console.WriteLine("No Play");
                    Console.WriteLine("I will stay in same position");
                    break;
            }
        }
    }
}