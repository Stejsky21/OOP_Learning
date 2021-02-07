using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Learning
{
    class Priklad2_2
    {
        public void Main()
        {
            int[] cisla = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            double result = 0;

            for (int i = 0; i < cisla.Length; i++)
            {
                result = result + cisla[i];
            }

            Console.WriteLine(result / cisla.Length);            
        }
    }
}
