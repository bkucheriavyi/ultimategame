using core;
using core.Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture(Category = "Integration")]
    public class MoveCommandPathReducerTests
    {

        [Test]
        [TestCase("MRMLMRM", "NMEMNMEM")]
        [TestCase("RMMMLMM", "EMEMEMNMNM")]
        [TestCase("MMMM", "NMNMNMNM")]
        [TestCase("RLLRMRRMMRM", "NMSMSMWM")]
        public void TestReduce_ReducesCommandsToAbsoluteNorthDirection(string input, string expected)
        {
            //given
            var reducer = new MoveCommandPathReducer(new DirectionLiteralsMapper());

            //when
            var result = reducer.Reduce(input, Direction.North);

            //then
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}