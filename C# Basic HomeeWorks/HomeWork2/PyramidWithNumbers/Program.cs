﻿using System;

namespace PyramidWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int spc, rows, k, t = 1;

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (int i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                    Console.Write("{0} ", t++);
                    Console.Write("\n");
                spc--;
            }
            Console.ReadLine();
        }
    }
}
