using System;

namespace BuilderPattern
{
    public class Walls
    {
        private int windowCount;

        public Walls(int windowCount)
        {
            if (windowCount < 0)
                throw new ArgumentException("There is no such thing as negative windows!");

            this.windowCount = windowCount;
        }
    }
}
