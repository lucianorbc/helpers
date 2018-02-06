namespace BuilderPattern
{
    public interface IHouseWithRoofSpecification
    {
        IBuildingSpecification<House> Validate();
    }
}
