using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sudoku.Game c = new Game();
            Random r = new Random();
            c.NewGame(r);
            Assert.AreEqual(c.r, r);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Sudoku.Game f = new Game();
            Random r = new Random();
            f.NewGame(r);
            Assert.AreEqual(f.r, r);
        }
    }
}