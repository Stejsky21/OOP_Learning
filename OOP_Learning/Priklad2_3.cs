using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Learning
{
    class Priklad2_3
    {
        public void Main()
        {
            int[] cisla = new int[] { 25, 24, 26, 45, 25, 23, 50, 51 };
            var result = 0;

            for (int i = 0; i < cisla.Length; i++)
            {
                if(cisla[i] >= 25 && cisla[i] <= 50)
                {
                    result++;        
                }
            }
            Console.WriteLine(result);
        }
    }
}
