namespace Algorithm_I.Day4
{
    public class ReverseStringProblem
    {
        /*
         * Write a function that reverses a string. The input string is given as an array of characters s.
         * You must do this by modifying the input array in-place with O(1) extra memory.
         */
        
        public static void Run(char[] word)
        {
            var sq = new ReverseStringProblem();
            sq.ReverseString(word);
        }
        public void ReverseString(char[] s) {
        
            if (s.Length <= 1) return;
            
            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                var tmp = s[start];
                s[start] = s[end];
                s[end] = tmp;
                start++;
                end--;
            }
        }
    }
}