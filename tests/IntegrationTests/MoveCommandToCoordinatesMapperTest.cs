using System;
using System.Linq;
using core;
using NUnit.Framework;

namespace tests.UnitTest
{
    [TestFixture(Category = "Integration")]
    public class MoveCommandToCoordinatesMapperTest
    {
        [Test]
        [TestCase("NMEMNMEM", "(0;1),(1;0),(0;1),(1;0)")]
        [TestCase("EMEMEMNMNM", "(1;0),(1;0),(1;0),(0;1),(0;1)")]
        [TestCase("NMNMNMNM", "(0;1),(0;1),(0;1),(0;1)")]
        [TestCase("NMSMSMWM", "(0;1),(0;-1),(0;-1),(-1;0)")]
        public void TestMap_CorrectInput_MappingIntoCoordinates(string input, string expected)
        {
            //given
            var directionMapper = new DirectionLiteralsMapper();
            var mapper = new MoveCommandToCoordinatesMapper(directionMapper);

            //when
            var resut = mapper.Map(input);

            //then
            Assert.That(string.Join(',', resut.Select(r => $"({r.X};{r.Y})")), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("RRRRRRRR")]
        [TestCase("RLRLRLR")]
        [TestCase("LLLLLLLL")]
        public void Test_Map_Throws(string input)
        {
            //given
            var directionMapper = new DirectionLiteralsMapper();
            var mapper = new MoveCommandToCoordinatesMapper(directionMapper);

            //when
            //then
            var ex = Assert.Throws<FormatException>(() => mapper.Map(input));
            Assert.That(ex.Message, Is.EqualTo("Missing move command"));
        }
    }
}