namespace Left.Recursion
{
    public class NQueenOPT
    {
        public int Solution(int n)
        {
            if (n<1||n>32)
            {
                return 0;
            }

            int limit = n == 32 ? -1 : (1 << n) - 1;
            return Process(limit, 0, 0, 0);
        }

        private int Process(int limit, int colLim, int leftDiaLim, int rightDiaLim)
        {
            if (colLim==limit)
            {
                return 1;
            }

            int pos = limit & (~(colLim | leftDiaLim | rightDiaLim));
            int mostRightOne = 0;
            int res = 0;
            while (pos!=0)
            {
                //其取出pos中,最右侧的1来,剩下位置都是0
                mostRightOne = pos & (~pos + 1);
                pos = pos - mostRightOne;
                res += Process(limit,
                    colLim | mostRightOne,
                    (leftDiaLim | mostRightOne) << 1,
                    (rightDiaLim | mostRightOne) >> 1);
                
            }

            return res;
            
        }
    }
}