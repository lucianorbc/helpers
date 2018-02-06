using System;

namespace BuilderPattern
{
    public class House
    {
        string houseAddress;
        Floor floor;
        Walls walls;
        Roof roof;
        public House(string houseAddress, Floor floor, Walls walls, Roof roof)
        {
            if (!HouseIsValid(floor, walls, roof))
                throw new ArgumentException("House is not valid!");

            this.houseAddress = houseAddress;
            this.floor = floor;
            this.walls = walls;
            this.roof = roof;
        }

        private static bool HouseIsValid(Floor floor, Walls walls, Roof roof)
        {
            return (floor != null && walls != null && roof != null)
                            || (floor != null && walls != null && roof == null)
                            || (floor != null && walls == null && roof == null)
                            || (floor == null && walls == null && roof == null);
        }

        public override string ToString()
        {
            return HouseIsValid(this.floor, this.walls, this.roof) ? "The house is standing!" : "The house fell apart!";
        }
    }
}
