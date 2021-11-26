using System;

namespace Algorithm_I.Day13
{
    public class PowerOfTwoProblem
    {
        /*
         * Given an integer n, return true if it is a power of two. Otherwise, return false.
         * An integer n is a power of two, if there exists an integer x such that n == 2x.
         */
        public bool IsPowerOfTwo(int n) {
            // every 2 base number should contains only have 1 bit and number of 0 bits
            // ex: 1 = 1, 2 = 10, 4 = 100 and if we subtract 1 from n it will have zero bit and 1 bits
            // ex: 0 = 0, 1, 01, 4 = 011 and with bitwise and to have 1 both should have 1
            // and this will make 10 & 01 = 00 = 0 int and this is our check
            return n > 0 && (n & n - 1) == 0;
            
            // another solution
            // get binary of n if first bit != 1 then is not power of two
            // then check every other bit of its not 0 then its not power of 2
            if (n < 0) return false;
            var binary = Convert.ToString(n, 2); // change number to binary
            if (binary[0] != '1') return false;
            
            for (var i = 1; i < binary.Length; i++)
            {
                if (binary[i] != '0') return false;
            }
            
            return true;
            
        }
    }
}