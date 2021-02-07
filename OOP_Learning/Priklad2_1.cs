using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Learning
{
    class Priklad2_1
    {
        public int Main(int plat)
        {
            if (plat < 1000)
            {
                Console.WriteLine("prvni");
            }
            else if (plat <= 3000)
            {
                Console.WriteLine("druhy");
            }
            else
            {
                Console.WriteLine("treti");
            }
            return plat;
        }
    }
}
