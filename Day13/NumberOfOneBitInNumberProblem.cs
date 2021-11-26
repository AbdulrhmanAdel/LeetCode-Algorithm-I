namespace Algorithm_I.Day13
{
    public class NumberOfOneBitInNumberProblem
    {

        /*
         * Write a function that takes an unsigned integer
         * and returns the number of '1' bits it has
         * (also known as the Hamming weight (http://en.wikipedia.org/wiki/Hamming_weight)).
         */
        public static int Run(uint n)
        {
            var p = new NumberOfOneBitInNumberProblem();
            return p.HammingWeight(n);
        }
        public int HammingWeight(uint n)
        {
            // n & n -1 remove one (1 bit) from n and so on unit n has no 1 so it will become 0
            var count = 0;
            while (n != 0)
            {
                n &= n - 1;
                count++;
            }

            return count;
        }
    }
}