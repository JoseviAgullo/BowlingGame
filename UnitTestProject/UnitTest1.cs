using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGame()
        {
            Game game = new Game();

            game.roll(0);

            Assert.AreEqual(0, game.score());
        }
    }
}
