namespace BuilderPattern
{
    public interface IRoofWithTile
    {
        IBuildingSpecification<Roof> HasColor(string roofTileColor);
    }
}
