using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testGutterGame()
        {
            Game game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }

            Assert.AreEqual(0, game.score());
        }

        [TestMethod]
        public void testAllFour()
        {
            Game game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.roll(4);
            }

            Assert.AreEqual(80, game.score());
        }
    }
}
