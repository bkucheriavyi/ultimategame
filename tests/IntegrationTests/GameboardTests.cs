using System;
using core;
using core.Model;
using NUnit.Framework;

namespace tests.IntegrationTests
{
    [TestFixture(Category = "Integration")]
    public class GameboardTests
    {
        [Test]
        public void TestMove_ExistingPicedMovedAndReturned()
        {
            //given
            var directionMapper = new DirectionLiteralsMapper();
            var gameboard = new Gameboard(5, 5, directionMapper);
            gameboard.Add(new Piece(0, 0, Direction.North));

            //when
            var result = gameboard.MovePiece(new Point(0, 0), new Point(1, 0));

            //then
            Assert.That(result.Position, Is.EqualTo(new Point(1, 0)));
            Assert.That(result.Direction, Is.EqualTo(Direction.East));
        }

        [Test]
        public void TestMove_MoveOutTheBoard_LatestValidPositionReturned()
        {
            //given
            var directionMapper = new DirectionLiteralsMapper();
            var gameboard = new Gameboard(5, 5, directionMapper);
            gameboard.Add(new Piece(0, 0, Direction.North));

            //when
            var result = gameboard.MovePiece(new Point(0, 0), new Point(-1, 0));

            //then
            Assert.That(result.Position, Is.EqualTo(new Point(0, 0)));
            Assert.That(result.Direction, Is.EqualTo(Direction.North));
        }
    }
}
