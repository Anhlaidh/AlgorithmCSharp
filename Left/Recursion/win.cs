using System;

namespace Left.Recursion
{
    public class win
    {
        public static int Solution(int[] arr)
        {
            if (arr==null||arr.Length==0)
            {
                return 0;
            }

            return Math.Max(f(arr, 0, arr.Length - 1), s(arr, 0, arr.Length - 1));
        }

        private static int s(int[] arr, int L, int R)
        {
            if (L==R)
            {
                return 0;
            }

            return Math.Min(arr[L]+f(arr, L + 1, R),arr[R]+ f(arr, L, R - 1));
        }

        private static int f(int[] arr, int L, int R)
        {
            if (L==R)
            {
                return arr[L];
            }

            return Math.Max(arr[L]+s(arr, L + 1, R), arr[R]+s(arr, L, R - 1));
        }
    }
}