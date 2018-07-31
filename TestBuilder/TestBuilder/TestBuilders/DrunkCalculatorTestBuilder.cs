using NUnit.Framework;
using TestBuilder.Helpers;
using TestBuilder.Services.Implementations;

namespace TestBuilder.TestBuilders
{
    public class DrunkCalculatorTestBuilder : TestBuilderBase<DrunkCalculator>
    {
        private int left;
        private int right;
        private int result;

        public DrunkCalculatorTestBuilder WhenLeftIs(int value)
        {
            left = value;
            return this;
        }

        public DrunkCalculatorTestBuilder WhenRighttIs(int value)
        {
            right = value;
            return this;
        }

        public DrunkCalculatorTestBuilder ActAdd()
        {
            result = Subject.Add(left, right);
            return this;
        }

        public DrunkCalculatorTestBuilder AssertThatResultIs(int value)
        {
            Assert.That(result, Is.EqualTo(value));
            return this;
        }


    }
}