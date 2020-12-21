using System;
using System.Data;

namespace Left.Dynamic
{
    public class RobotWalk
    {
        /**
        - 假设有拍成一行的N个位置,记录为1-N ,N一定大于或者等于2,开始时机器人在其中的M位置上(M一定是1~N中的一个)
        - 如果机器人来到1位置,那么下一步只能往右来到2位置
        - 如果机器人来到N位置,那么下一步只能往左来到N-1位置
        - 如果机器人来到中间位置,那么下一步可以往左或者往右走
        - 规定机器人必须走K步,最终能来到P位置(P也是1~N中的一个)的方法有很多种
         */
        // N(规模),M(初始位置),K(需要的步数),P(目标)
        public int Solution()
        {
            int N = 7;
            int M = 2;
            int K = 5;
            int P = 3;
            
            if (N<2||K<1||M<1||M>N||P<1||P>N)
            {
                return 0;
            }
            // return RecursionMethod(N, M, K, P);
            int[,] dp = new int[N+1,K+1];
            
            for (int i = 0; i <N+1; i++)
            {
                for (int j = 0; j < K+1; j++)
                {
                    dp[i, j] = -1;
                }
                
            }

            Console.WriteLine(RecursionMethod(N, M, K, P));
            Console.WriteLine(CacheMethod(N, M, K, P,dp));
            return CacheMethod(N, M, K, P, dp);
            
        }

        #region RecursionMethod

        private int RecursionMethod(int N, int cur, int rest, int P)
        {
            if (rest == 0)
            {
                return cur == P ? 1 : 0;
            }

            if (cur==1)
            {
                return RecursionMethod(N, 2, rest - 1, P);
            }

            if (cur==N)
            {
                return RecursionMethod(N, N - 1, rest - 1, P);
            }

            return RecursionMethod(N, cur + 1, rest - 1, P) + RecursionMethod(N, cur - 1, rest - 1, P);
        }
        

        #endregion

        #region CacheMethod

        private int CacheMethod(int N, int cur, int rest, int P,int[,] dp)
        {
            if (dp[cur,rest]!=-1)
            {
                return dp[cur, rest];
            }
            if (rest == 0)
            {
                dp[cur,rest] =  cur == P ? 1 : 0;
                return dp[cur, rest];  
            }

            if (cur==1)
            {
                dp[cur,rest] =  CacheMethod(N, 2, rest - 1, P,dp);
                return dp[cur, rest]; 
            }

            if (cur==N)
            {
                dp[cur,rest] =  CacheMethod(N, N - 1, rest - 1, P,dp);
                return dp[cur, rest]; 
            }

            dp[cur, rest] = CacheMethod(N, cur + 1, rest - 1, P, dp) + CacheMethod(N, cur - 1, rest - 1, P, dp);
            
            return dp[cur, rest]; 
        }

        #endregion
    }
}