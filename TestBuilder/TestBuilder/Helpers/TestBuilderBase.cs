using NSubstitute;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;

namespace TestBuilder.Helpers
{
    public class TestBuilderBase<T> where T : class
    {
        protected IFixture Fixture { get; } = new Fixture().Customize(new AutoNSubstituteCustomization());
        public T Get<T>() where T : class => Fixture.Create<T>();
        protected T GetFrozen<T>() where T : class => Fixture.Freeze<T>();
        public T Received<T>() where T : class => Fixture.Create<T>().Received();
        public T ReceivedWithAnyArgs<T>() where T : class => Fixture.Create<T>().ReceivedWithAnyArgs();
        public T DidNotReceiveWithAnyArgs<T>() where T : class => Fixture.Create<T>().DidNotReceiveWithAnyArgs();
        protected T Subject { get; private set; }

        public TestBuilderBase<T> Build()
        {
            Subject = this.Get<T>();
            return this;
        }
    }
}
