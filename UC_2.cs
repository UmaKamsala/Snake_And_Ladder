using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder
{
    class UC_2
    {
        public void DieRoll()
        {
            Random random = new Random();
            int rollCheck = random.Next(1, 7);
            Console.WriteLine("Number got on Die: " + rollCheck);
        }
    }
}
