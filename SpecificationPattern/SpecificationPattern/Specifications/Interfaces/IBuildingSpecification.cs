namespace BuilderPattern
{
    public interface IBuildingSpecification<T>
    {
        T Build();
    }
}
