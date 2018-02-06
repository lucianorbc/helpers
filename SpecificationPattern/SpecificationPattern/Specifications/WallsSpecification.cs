using System;

namespace BuilderPattern
{
    public class WallsSpecification : IWallsSpecification, IBuildingSpecification<Walls>
    {
        private int windowCount;

        private WallsSpecification(int windowCount)
        {
            this.windowCount = windowCount;
        }
        public static IWallsSpecification Initialize()
        {
            return new WallsSpecification(0);
        }
        public Walls Build()
        {
            return new Walls(this.windowCount);
        }
        public IBuildingSpecification<Walls> WithWindows(int windowCount)
        {
            if (windowCount < 0)
                throw new ArgumentException("There is no such thing as negative windows!");

            return new WallsSpecification(windowCount);
        }
    }
}
