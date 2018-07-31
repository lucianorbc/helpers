using NUnit.Framework;
using TestBuilder.TestBuilders;

namespace TestBuilder.Tests
{
    [TestFixture]
    public class DrunkCalculatorTest
    {
        private DrunkCalculatorTestBuilder builder;

        [SetUp]
        public void SetUp()
        {
            builder = new DrunkCalculatorTestBuilder();
        }

        [Test]
        public void Add_WhenSameNumberAdded_ReturnsZero()
        {
            //Arrange
            builder.WhenLeftIs(1)
                .WhenRighttIs(1)
                .Build();

            //Act
            builder.ActAdd();

            //Assert
            builder.AssertThatResultIs(0);
        }

        [Test]
        [TestCase(1,2)]
        [TestCase(3, 2)]
        public void Add_WhenDifferentNumbersAdded_ReturnsCorrectCalculation(int left, int right)
        {
            //Arrange
            builder.WhenLeftIs(left)
                .WhenRighttIs(right)
                .Build();

            //Act
            builder.ActAdd();

            //Assert
            builder.AssertThatResultIs(left + right);
        }
    }
}
