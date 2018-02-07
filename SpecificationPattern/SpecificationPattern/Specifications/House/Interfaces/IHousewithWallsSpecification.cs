namespace BuilderPattern
{
    public interface IHousewithWallsSpecification
    {
        IHouseWithRoofSpecification WithRoof(IBuildingSpecification<Roof> roof);
    }
}
