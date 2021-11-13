using System;
using Algorithm_I.Day1;

namespace Algorithm_I
{
    class Program
    {
        static void Main(string[] args)
        {
            var binarySerach = new BinarySearch();

            Console.WriteLine(binarySerach.Search(new[] {1, 2, 3, 4, 5, 6, 7, 8}, 8));
        }
    }
}