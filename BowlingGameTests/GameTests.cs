using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;


namespace BowlingGameTests
{
    [TestClass]
    public class GameTests
    {
        private Bowling game;

        [TestInitialize]
        public void Initialize()
        {
            game = new Bowling();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            for (var i = 0; i < 20; i++)
                game.Roll(0);

            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            for (var i = 0; i < 20; i++)
                game.Roll(1);

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);

            for (var i = 0; i < 17; i++)
                game.Roll(0);

            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            game.Roll(10);
            for (int lcv = 1; lcv < 20; lcv++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(10, game.Score());
        }

        [TestMethod]
        public void TestSpareInTenthFrame()
        {
            for (int lcv = 0; lcv < 18; lcv++)
            {
                game.Roll(0);
            }
            game.Roll(2);
            game.Roll(8);
            game.Roll(7);

            Assert.AreEqual(17, game.Score());
        }

        [TestMethod]
        public void TestStrikeInTenthFrame()
        {
            for (int lcv = 0; lcv < 18; lcv++)
            {
                game.Roll(0);
            }

            game.Roll(10);
            game.Roll(2);
            game.Roll(7);
            Assert.AreEqual(19, game.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            for (int lcv = 0; lcv <12; lcv++)
            {
                game.Roll(10);
            }

            Assert.AreEqual(300, game.Score());
        }
    }
}
