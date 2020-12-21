using System;
using System.Collections.Generic;
using System.Text;

namespace Left.Recursion
{
    public class NQueen
    {
        public int Solution(int N)
        {
            if (N==0)
            {
                return 0;
            }
            int[][] position = new int[N][];
            int process = Process(position, 0, N);
            return process;
        }

        private int Process(int[][] position, int index, int N)
        {
            if (index == N)
            {
                return 1;
            }

            int result = 0;
            //尝试 不存在就返回0
            for (int i = 0; i < N; i++)
            {
                //同列或者同斜线 返回0
                if (SameColumn(position, i, index) || SameSlash(position, i, index))
                {
                    continue;
                }
                //可以放置 进行递归 
                else
                {
                    position[index] = new[] {index, i};
                    result += Process(position, index + 1, N);
                    position[index] = null;
                }
            }

            return result;
        }

        private bool SameSlash(int[][] position, int column, int index)
        {
            for (int i = 0; i < index; i++)
            {
                int l = position[i][0];
                int c = position[i][1];
                int dol = index - l;
                if (column == c + dol || column == c - dol)
                {
                    return true;
                }
            }

            return false;
        }

        private bool SameColumn(int[][] position, int column, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (position[i][1] == column)
                {
                    return true;
                }
            }

            return false;
        }


       public class LeetCode
        {
            public IList<IList<string>> SolveNQueens(int n)
            {
                int[][] position = new int[n][];
                IList<IList<string>> results = new List<IList<string>>();
                Process(position, 0, n, results);
                return results;
            }

            private int Process(int[][] position, int index, int N, IList<IList<string>> results)
            {
                if (index == N)
                {
                    results.Add(new List<string>(GetString(position,N)));
                    return 1;
                }

                int result = 0;
                //尝试 不存在就返回0
                for (int i = 0; i < N; i++)
                {
                    //同列或者同斜线 返回0
                    if (SameColumn(position, i, index) || SameSlash(position, i, index))
                    {
                        continue;
                    }
                    //可以放置 进行递归 
                    else
                    {
                        position[index] = new[] {index, i};
                        result += Process(position, index + 1,N,results );
                        position[index] = null;
                    }
                }

                return result;
            }

            private string[] GetString(int[][] position,int N)
            {
                String[] strings = new string[position.Length];
                for (int i = 0; i < position.Length; i++)
                {
                    int col = position[i][1];
                    StringBuilder cur = new StringBuilder();
                    for (int j = 0; j < N; j++)
                    {
                        if (j!=col)
                        {
                            cur.Append('.');
                        }
                        else
                        {
                            cur.Append('Q');
                        }
                    }

                    strings[i] = cur.ToString();
                }

                return strings;
                
            }

            private bool SameSlash(int[][] position, int column, int index)
            {
                for (int i = 0; i < index; i++)
                {
                    int l = position[i][0];
                    int c = position[i][1];
                    int dol = index - l;
                    if (column == c + dol || column == c - dol)
                    {
                        return true;
                    }
                }

                return false;
            }

            private bool SameColumn(int[][] position, int column, int index)
            {
                for (int i = 0; i < index; i++)
                {
                    if (position[i][1] == column)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}