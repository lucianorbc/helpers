namespace BuilderPattern
{
    public interface IFloorSpecification
    {
        IBuildingSpecification<Floor> WithTiles(int tileCount);
    }
}
