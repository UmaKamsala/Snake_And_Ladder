using System;

namespace Snake_And_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Program");

            UC_1 uc1 = new UC_1();
            uc1.Game();

            UC_2 dieRoll = new UC_2();
            dieRoll.DieRoll();

            UC_3 game = new UC_3();
            game.Play();

            UC_4 player = new UC_4();
            player.Game();

            UC_5 win = new UC_5();
            win.Win();

            UC_6 diecount = new UC_6();
            diecount.DieCount();

            UC_7 twoPlayers = new UC_7();
            twoPlayers.Playing();

        }
    }
}
