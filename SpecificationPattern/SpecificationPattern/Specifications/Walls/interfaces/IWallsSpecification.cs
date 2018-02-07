namespace BuilderPattern
{
    public interface IWallsSpecification
    {
        IBuildingSpecification<Walls> WithWindows(int windowCount);
    }
}
