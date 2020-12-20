using System;
using System.Collections.Generic;
using Left.Recursion;
using NUnit.Framework;

namespace Run
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Base()
        {
            for (int i = 0; i < 10; i++)
            {
            }
        }

        //汉诺塔
        [Test]
        public void HanoiTest()
        {
            Hanoi.Solution();
            Assert.Pass();
        }

        //最大值
        [Test]
        public void GetMaxValue()
        {
            int[] w = new[] {1, 3, 5, 7, 9};
            int[] v = new[] {2, 4, 6, 8, 10};
            int bag = 15;


            Left.Recursion.GetMaxValue.Solution(w, v, bag);

            Assert.Pass();
        }
        //取最大分数  博弈论 
        [Test]
        public void win()
        {
            int[] poke = new[] {4, 7, 100, 70};
            int i = Left.Recursion.win.Solution(poke);
            Console.WriteLine(i);

            Assert.Pass();
        }

        [Test]
        public void NQueue()
        {
            NQueen.LeetCode question = new NQueen.LeetCode();
            IList<IList<string>> result = question.SolveNQueens(4);
            
            Console.WriteLine(result);
            
        }
    }
}