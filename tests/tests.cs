using core;
using NUnit.Framework;

namespace Tests
{
    [TestFixture(Category ="Integration")]
    public class Tests
    {

        [Test]
        [TestCase("MRMLMRM", "NMEMNMEM")]
        [TestCase("RMMMLMM", "EMEMEMNMNM")]
        [TestCase("MMMM", "NMNMNMNM")]
        [TestCase("RLLRMRRMMRM", "NMSMSMWM")]
        public void Test_Reduce_ReducesCommandsToAbsoluteNorthDirection(string input, string expected)
        {
            //given
            var reducer = new CommandPathReducer(new DirectionLiteralsMapper());
            //when
            var result = reducer.Reduce(input, Direction.North);
            //then
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}