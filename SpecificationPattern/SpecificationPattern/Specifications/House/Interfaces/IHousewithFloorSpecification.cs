namespace BuilderPattern
{
    public interface IHousewithFloorSpecification
    {
        IHousewithWallsSpecification WithWalls(IBuildingSpecification<Walls> walls);
    }
}
