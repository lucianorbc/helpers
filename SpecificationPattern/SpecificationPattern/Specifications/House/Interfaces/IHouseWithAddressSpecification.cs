namespace BuilderPattern
{
    public interface IHouseWithAddressSpecification
    {
        IHousewithFloorSpecification WithFloor(IBuildingSpecification<Floor> floor);
    }
}
