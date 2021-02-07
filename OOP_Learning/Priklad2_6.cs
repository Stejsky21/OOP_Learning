using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Learning
{
    class Priklad2_6
    {
        public void Main()
        {
            int[][] matice = {  new int[] { 1, 2, 3, },
                                new int[] { 4, 5, 6, },
                                new int[] { 7, 8, 9, },
                                new int[] { 10, 11, 12, }};


            for (int i = 0; i < matice[i].Length; i++)
            {
                var sloupec = 0;

                for (int j = 0; j < matice.Length; j++)
                {
                    sloupec += matice[j][i];
                }
                Console.WriteLine(sloupec / 4);
            }

            for (int j = 0; j < matice.Length; j++)
            {
                var radek = 0;

                for (int i = 0; i < matice[i].Length; i++)
                {
                    radek += matice[j][i];
                }
                Console.WriteLine(radek / 3);
            }
        }
    }
}
