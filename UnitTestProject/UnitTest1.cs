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

        private void rollSpare()
        {
            game.roll(5);
            game.roll(5);
        }

        private void rollStrike()
        {
            game.roll(10);
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
            rollSpare();
            game.roll(6);
            rollMany(17, 0);

            Assert.AreEqual(22, game.score());
        }

        [TestMethod]
        public void testStrike()
        {
            rollStrike();
            game.roll(3);
            game.roll(5);
            rollMany(16, 0);

            Assert.AreEqual(26, game.score());
        }
    }
}
