using System;

namespace BuilderPattern
{
    public class Floor
    {
        private int tileCount;

        public Floor(int tileCount)
        {
            if (tileCount <= 0)
                throw new ArgumentException("Floor should have at least one tile!");

            this.tileCount = tileCount;
        }
    }
}
