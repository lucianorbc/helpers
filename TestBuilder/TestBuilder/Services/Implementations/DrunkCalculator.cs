namespace TestBuilder.Services.Implementations
{
    public class DrunkCalculator : IDrunkCalculator
    {
        public int Add(int left, int right)
        {
            return left == right ? 0 : left + right;
        }
    }
}
