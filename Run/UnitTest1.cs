using System;
using System.Collections.Generic;
using Left.Dynamic;
using Left.Recursion;
using Nest;
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

        [Test]
        public void NQueenOPT()
        {
            Left.Recursion.NQueenOPT queenOpt = new NQueenOPT();

            NQueen question = new NQueen();
            
            for (int i = 0; i < 15; i++)
            {
                int begin = DateTime.Now.Millisecond;    
                int solution = queenOpt.Solution(i);
                int end = DateTime.Now.Millisecond;
                int normal = end - begin;
                begin = DateTime.Now.Millisecond;

                int result = question.Solution(i);
                int opt = end - begin;
                Console.WriteLine("current is "+i);
                Console.WriteLine("normal:" + result + "   用时:" + normal);
                Console.WriteLine("OPT:" + solution + "   用时:" + opt);
                Console.WriteLine("=====================");
            }
        }

        [Test]
        public void Robot()
        {
            RobotWalk question = new RobotWalk();
            question.Solution();
            
        }

    }
}