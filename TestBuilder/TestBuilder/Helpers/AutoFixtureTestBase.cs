using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;

namespace TestBuilder.Helpers
{
    /// <summary>
    /// Inherit this class and get access to IFeature capabilities
    /// </summary>
    /// <typeparam name="T">The test subject</typeparam>
    public abstract class AutoFixtureTestBase<T> where T : class
    {
        protected IFixture Fixture { get; private set; }

        /// <summary>
        /// Returns the subject being tested
        /// </summary>
        protected T Subject
        {
            get
            {
                if (Fixture == null)
                {
                    throw new ArgumentException($"Fixture is not setup. Please call {nameof(ResetFixture)} before calling {nameof(Subject)}");
                }

                return Fixture.Create<T>();
            }
        }

        [SetUp]
        public void BaseSetup()
        {
            ResetFixture();
        }

        /// <summary>
        /// Used to setup/reset IFixture instance
        /// </summary>
        protected void ResetFixture()
        {
            Fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
        }
    }
}
