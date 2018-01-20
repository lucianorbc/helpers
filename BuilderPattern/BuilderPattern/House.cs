namespace BuilderPattern
{
    public class House
    {
        bool hasFloor;
        bool hasWalls;
        bool hasRoof;
        public House(bool hasFloor, bool hasWalls, bool hasRoof)
        {
            this.hasFloor = hasFloor;
            this.hasWalls = hasWalls;
            this.hasRoof = hasRoof;
        }
        public override string ToString()
        {
            return
                IsValid() ? "The house is standing!" : "The house fell apart!";
        }
        private bool IsValid()
        {
            return (hasFloor && hasWalls && hasRoof)
                || (hasFloor && hasWalls && !hasRoof)
                || (hasFloor && !hasWalls && !hasRoof)
                || (!hasFloor && !hasWalls && !hasRoof);
        }
    }
}
