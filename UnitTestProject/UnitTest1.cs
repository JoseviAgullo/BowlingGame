using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Game game;

        [TestInitialize]
        public void setUp()
        {
            game = new Game();
        }

        private void rollMany(int times, int pins)
        {
            for (int i = 0; i < times; i++)
            {
                game.roll(pins);
            }
        }

        [TestMethod]
        public void testGutterGame()
        {
            rollMany(20, 0);

            Assert.AreEqual(0, game.score());
        }

        [TestMethod]
        public void testAllFour()
        {
            rollMany(20, 4);

            Assert.AreEqual(80, game.score());
        }
        
        [TestMethod]
        public void testSpare()
        {
            game.roll(5);
            game.roll(5);
            game.roll(6);
            rollMany(17, 0);
            Assert.AreEqual(22, game.score());
        }

        
    }
}
