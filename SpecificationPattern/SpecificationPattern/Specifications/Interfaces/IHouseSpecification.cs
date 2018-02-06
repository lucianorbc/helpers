namespace BuilderPattern
{
    public interface IHouseSpecification
    {
        IHouseWithAddressSpecification WithAddress(string address);
    }
}
