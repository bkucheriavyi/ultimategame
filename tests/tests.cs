using core;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        [Test]
        [Ignore("Not implemented yet")]
        [TestCase("MRMLMRM","22E")]
        [TestCase("RMMMLMM", "32N")]
        [TestCase("MMMMM", "04N")]
        [TestCase("MMMMMM", "")]
        [TestCase("RMMMMMM", "")]
        [TestCase("RMMMMMM", "")]
        [TestCase("RMMMMMM", "")]
        public void Test(string input, string expected)
        {
            //given
        //   var commanProcessor = new CommandProcessor();
            var game = new CommandPathReducer();

            //when
        //   game.Move(input);

            //then
            Assert.That(true, Is.EqualTo(false));
        }

        [Test]
        [TestCase("MRMLMRM", "NMEMNMEM")]
        [TestCase("RMMMLMM", "EMEMEMNMNM")]
        [TestCase("MMMM", "NMNMNMNM")]
        [TestCase("RLLRMRRMMRM", "NMSMSMWM")]
        public void Test1(string input, string expected)
        {
            //given
            var reducer = new CommandPathReducer();
            //when
            var result = reducer.Reduce(input, Direction.North);
            //then
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}