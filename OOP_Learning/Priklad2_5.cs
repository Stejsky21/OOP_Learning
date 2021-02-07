using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Learning
{
    class Priklad2_5
    {
        public void Main()
        {
            int[] main = new int[] { 24, 26, 25, 45, 25, 23, 50, 51 };
            var hodnota = 48;
            var index = 0;

            for (int i = 0; i < main.Length; i++)
            {
                if(hodnota == main[i])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
                
            }
            Console.WriteLine(index);
        }
    }
}
