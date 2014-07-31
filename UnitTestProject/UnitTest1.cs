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

        [TestMethod]
        public void testSpareLastFrame()
        {
            rollMany(18, 0);
            rollSpare();
            game.roll(5);

            Assert.AreEqual(15, game.score());
        }

        [TestMethod]
        public void testStrikeLastFrame()
        {
            rollMany(18, 0);
            rollStrike();
            game.roll(5);
            game.roll(4);

            Assert.AreEqual(19, game.score());
        }

        [TestMethod]
        public void testSpareLastRollLastFrame()
        {
            rollMany(18, 0);
            rollStrike();
            rollSpare();

            Assert.AreEqual(20, game.score());
        }

        [TestMethod]
        public void testStrikeLastRollLastFrame()
        {
            rollMany(18, 0);
            rollSpare();
            rollStrike();

            Assert.AreEqual(20, game.score());
        }

        [TestMethod]
        public void testPerfectGame()
        {
            rollMany(12, 10);

            Assert.AreEqual(300, game.score());
        }

        [TestMethod]
        public void testRealGame()
        {
            game.roll(1);
            game.roll(4);
            game.roll(4);
            game.roll(5);            
            game.roll(6);
            game.roll(4);
            game.roll(5);
            game.roll(5);
            rollStrike();
            game.roll(0);
            game.roll(1);
            game.roll(7);
            game.roll(3);
            game.roll(6);
            game.roll(4);
            rollStrike();
            game.roll(2);
            game.roll(8);
            game.roll(6);

            Assert.AreEqual(133, game.score());
        }
    }
}
