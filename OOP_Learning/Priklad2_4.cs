using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Learning
{
    class Priklad2_4
    {
        public void Main()
        {
            int[] cisla = new int[] { 25, 24, 26, 45, 25, 23, 50, 51 };
            var result = 0;
            var i = 0;

            while (i < cisla.Length)
            {
                if (cisla[i] >= 25 && cisla[i] <= 50)
                {
                    result++;
                }
                i++;
            }
            Console.WriteLine(result);
        }
        public void Main2()
        {
            int[] cisla = new int[] { 25, 24, 26, 45, 25, 23, 50, 51, 30 };
            var result = 0;
            var i = 0;

            do
            {
                if (cisla[i] >= 25 && cisla[i] <= 50)
                {
                    result++;
                }
                i++;
            } while (i < cisla.Length);

            Console.WriteLine(result);
        }
    }
}
