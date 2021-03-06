namespace Algorithm_I.Day1
{
    /*
         You are a product manager and currently leading a team to develop a new product. 
         Unfortunately, the latest version of your product fails the quality check. 
         Since each version is developed based on the previous version, 
         all the versions after a bad version are also bad.
         Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, 
         which causes all the following ones to be bad.
         You are given an API bool isBadVersion(version) which returns whether version is bad. 
         Implement a function to find the first bad version. 
         You should minimize the number of calls to the API.
        */
    public class FirstBadVersionProblem
    {
        public int FirstBadVersion(int n)
        {
            if (n == 1) return 1;

            var start = 1;
            var end = n;

            while (start < end)
            {
                var mid = start + (end - start) / 2;
                if (IsBadVersion(mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return start;
        }

        bool IsBadVersion(int version)
        {
            return version > 3;
        }
    }
}