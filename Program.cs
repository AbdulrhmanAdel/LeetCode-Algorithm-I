using System;
using Algorithm_I.Day1;
using Algorithm_I.Day2;
using Algorithm_I.Day3;
using Algorithm_I.Day4;
using Algorithm_I.Day6;
using Algorithm_I.Day7;

namespace Algorithm_I
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxAreaOfIslandProblem.Run(new int[][]
            {
                new [] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new [] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                new [] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                new [] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new [] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}
            });
        }
    }
}