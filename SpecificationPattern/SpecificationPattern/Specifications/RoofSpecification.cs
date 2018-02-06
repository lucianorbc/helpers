using System;

namespace BuilderPattern
{
    public class RoofSpecification : IRoofSpecification, IRoofWithTile, IBuildingSpecification<Roof>
    {
        private int roofTileCount;
        private string roofTileColor;

        private RoofSpecification(int roofTileCount, string roofTileColor)
        {
            this.roofTileCount = roofTileCount;
            this.roofTileColor = roofTileColor;
        }

        public static IRoofSpecification Initialize()
        {
            return new RoofSpecification(0, "");
        }

        public IRoofWithTile HasRoofTiles(int roofTileCount)
        {
            if (roofTileCount < 0)
                throw new ArgumentException("Roof should have at least one roof tile!");

            return new RoofSpecification(roofTileCount, this.roofTileColor);
        }

        public IBuildingSpecification<Roof> HasColor(string roofTileColor)
        {
            if (string.IsNullOrEmpty(roofTileColor))
                throw new ArgumentException("Roof color was not specified!");

            return new RoofSpecification(this.roofTileCount, roofTileColor);
        }

        public Roof Build()
        {
            return new Roof(this.roofTileCount, this.roofTileColor);
        }
    }
}
