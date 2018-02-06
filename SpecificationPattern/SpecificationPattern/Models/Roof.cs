using System;

namespace BuilderPattern
{
    public class Roof
    {
        private int roofTileCount;
        private string roofTileColor;

        public Roof(int roofTileCount, string roofTileColor)
        {
            if (roofTileCount < 0)
                throw new ArgumentException("Roof should have at least one roof tile!");
            if (string.IsNullOrEmpty(roofTileColor))
                throw new ArgumentException("Roof color was not specified!");

            this.roofTileCount = roofTileCount;
            this.roofTileColor = roofTileColor;
        }
    }
}
