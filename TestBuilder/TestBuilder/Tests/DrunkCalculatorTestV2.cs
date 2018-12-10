using NUnit.Framework;
using TestBuilder.Helpers;
using TestBuilder.Services.Implementations;

namespace TestBuilder.Tests
{
    [TestFixture]
    public class DrunkCalculatorTestV2 : AutoFixtureTestBase<DrunkCalculator>
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void Add_WhenSameNumberAdded_ReturnsZero()
        {
            //Arrange
            var expectedResult = 0;

            //Act
            var result = Subject.Add(1, 1);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult), $"Expected result equal to {expectedResult}");
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(3, 2)]
        public void Add_WhenDifferentNumbersAdded_ReturnsCorrectCalculation(int left, int right)
        {
            //Arrange
            var expectedResult = left + right;

            //Act
            var result = Subject.Add(left, right);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult), $"Expected result equal to {expectedResult}");
        }
    }
}

