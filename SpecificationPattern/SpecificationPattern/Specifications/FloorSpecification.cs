using System;

namespace BuilderPattern
{
    public class FloorSpecification : IFloorSpecification, IBuildingSpecification<Floor>
    {
        private int tileCount;

        private FloorSpecification(int tileCount)
        {
            this.tileCount = tileCount;
        }

        public static IFloorSpecification Initialize()
        {
            return new FloorSpecification(0);
        }

        public IBuildingSpecification<Floor> WithTiles(int tileCount)
        {
            if (tileCount <= 0)
                throw new ArgumentException("Floor should have at least one tile!");

            return new FloorSpecification(tileCount);
        }

        public Floor Build()
        {
            return new Floor(this.tileCount);
        }
    }
}
