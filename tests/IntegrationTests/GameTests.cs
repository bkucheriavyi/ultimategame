using core;
using core.Model;
using NUnit.Framework;

namespace tests
{
    [TestFixture(Category = "Integration")]
    public class GameTests
    {
        [Test]
        [TestCase("MRMLMRM", "22E")]
        [TestCase("RMMMLMM", "32N")]
        [TestCase("MMMM", "04N")]
        [TestCase("RLLRMRRMMRM", "00S")]
        public void TestPlay_ShouldReturnCorrectResut(string input, string expected)
        {
            //given
            var directionsMapper = new DirectionLiteralsMapper();

            //TODO: Move directionsMapper as part of methods call and it will become a dependency into Game class
            var game = new Game(
                new Gameboard(5, 5, directionsMapper), 
                new MoveCommandPathReducer(directionsMapper),
                new MoveCommandToCoordinatesMapper(directionsMapper),
                new DefaultResultFormatter(directionsMapper));

            //when
            var result = game.Play(new Piece(0, 0, Direction.North), input, Direction.North);

            //then
            Assert.That(result.Result, Is.EqualTo(expected));
        }
    }
}
