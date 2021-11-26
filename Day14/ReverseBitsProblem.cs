using System.Collections;
using System.Globalization;

namespace Algorithm_I.Day14
{
    public class ReverseBitsProblem
    {
        /*
         * reverse bits of a given 32 bits unsigned integer.
         */
        public uint reverseBits(uint n)
        {
            uint result = 0; // 0000_0000_0000_0000_0000_0000_0000_0000
            for (var i = 0; i < 32; i++)
            {
                result <<= 1; // left shift will make room for new bit to be inserted default will be 0
                if ((n & 1) == 0) result++; // here check if the bit is 1 then insert 1 instead of default 0
                n >>= 1; // here drop the bit that we inserted into result by right shit it
            }

            return result;
        }
    }
}