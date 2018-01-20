namespace BuilderPattern
{
    public interface IHouseEmpty
    {
        IHouseWithFloor AddFloor();
    }
    public interface IHouseWithFloor
    {
        IHouseWithWalls AddWalls();
    }
    public interface IHouseWithWalls
    {
        IHouseWithRoof AddRoof();
    }
    public interface IHouseWithRoof
    {
        House Build();
    }
    public class HouseBuilder : IHouseEmpty, IHouseWithFloor, IHouseWithWalls, IHouseWithRoof
    {
        bool hasFloor;
        bool hasWalls;
        bool hasRoof;
        private HouseBuilder() { }
        public static IHouseEmpty Init()
        {
            return new HouseBuilder();
        }
        public IHouseWithFloor AddFloor()
        {
            hasFloor = true;
            return this;
        }
        public IHouseWithWalls AddWalls()
        {
            hasWalls = true;
            return this;
        }
        public IHouseWithRoof AddRoof()
        {
            hasRoof = true;
            return this;
        }
        public House Build()
        {
            return new House(hasFloor, hasWalls, hasRoof);
        }
    }
}
