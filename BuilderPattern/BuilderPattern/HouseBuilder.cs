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
        private HouseBuilder(bool hasFloor, bool hasWalls, bool hasRoof)
        {
            this.hasFloor = hasFloor;
            this.hasWalls = hasWalls;
            this.hasRoof = hasRoof;
        }
        public static IHouseEmpty Init()
        {
            return new HouseBuilder(false, false, false);
        }
        public IHouseWithFloor AddFloor()
        {
            return new HouseBuilder(true, this.hasWalls, this.hasRoof);
        }
        public IHouseWithWalls AddWalls()
        {
            return new HouseBuilder(this.hasFloor, true, this.hasRoof);

        }
        public IHouseWithRoof AddRoof()
        {
            return new HouseBuilder(this.hasFloor, this.hasWalls, true);
        }
        public House Build()
        {
            return new House(this.hasFloor, this.hasWalls, this.hasRoof);
        }
    }
}
