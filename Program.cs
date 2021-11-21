using System;
using Algorithm_I.Day1;
using Algorithm_I.Day2;
using Algorithm_I.Day3;
using Algorithm_I.Day4;
using Algorithm_I.Day6;
using Algorithm_I.Day7;
using Algorithm_I.Day9;

namespace Algorithm_I
{
    class Program
    {
        static void Main(string[] args)
        {
            RottingOrangesProblem.Run(new int[][]
            {
                new int[] {1, 1, 0, 0, 1, 0, 0, 1, 1, 0},
                new int[] {1, 0, 0, 1, 0, 1, 1, 1, 1, 1},
                new int[] {1, 1, 1, 0, 0, 1, 1, 1, 1, 0},
                new int[] {0, 1, 1, 1, 0, 1, 1, 1, 1, 1},
                new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                new int[] {1, 1, 1, 1, 1, 1, 0, 1, 1, 1},
                new int[] {0, 1, 1, 1, 1, 1, 1, 0, 0, 1},
                new int[] {1, 1, 1, 1, 1, 0, 0, 1, 1, 1},
                new int[] {0, 1, 0, 1, 1, 0, 1, 1, 1, 1},
                new int[] {1, 1, 1, 0, 1, 0, 1, 1, 1, 1}
            });
        }
    }
}