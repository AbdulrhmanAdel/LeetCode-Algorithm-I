namespace Algorithm_I.Day12
{
    public class ClimbingStairsProblem
    {
        /*
         * You are climbing a staircase. It takes n steps to reach the top.
         * Each time you can either climb 1 or 2 steps.
         * In how many distinct ways can you climb to the top?
         */
        public static int Run(int n)
        {
            var problem = new ClimbingStairsProblem();
            return problem.ClimbStairs(n);
        }

        public int ClimbStairs(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            // number of step to go to 2
            var oneStepBefore = 2;
            // number of step to go to 1
            var twoStepBefore = 1;
            
            // number of step to go to n =
            // (number of step to go to n - 2 + number of step to go to n - 1)
            // as from there you can take only one step to n (2 or 1 recursively)
            var allWay = 0;


            for (var i = 2; i < n; i++)
            {
                allWay = oneStepBefore + twoStepBefore;
                twoStepBefore = oneStepBefore;
                oneStepBefore = allWay;
            }

            return allWay;
        }
    }
}