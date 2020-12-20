using System;

namespace Left.Recursion
{
    public class GetMaxValue
    {
        public static void Solution(int[] w,int[] v, int bag)
        {
            Console.WriteLine(Process(w,v,0,0,bag));
        }

        private static int Process(int[] w, int[] v,int index,int alreadyW, int bag)
        {
            if (alreadyW>bag)
            {
                return -1;
            }
            //放完且没超
            if (index==w.Length)
            {
                return 0;
            }
            //当前不要
            int v1 = Process(w, v, index+1, alreadyW, bag);
            // 当前要
            int v2 = -1;
            
            int process = Process(w, v, index+1, alreadyW + w[index], bag);

            if (process!=-1)
            {
                v2 = v[index] + process;
            }

            return Math.Max(v1, v2);
        }
    }
}