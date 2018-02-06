using System;

namespace BuilderPattern
{
    public class HouseSpecification : IHouseSpecification, IHouseWithAddressSpecification, IHousewithFloorSpecification, IHousewithWallsSpecification, IHouseWithRoofSpecification, IBuildingSpecification<House>
    {
        string address;
        IBuildingSpecification<Floor> floor;
        IBuildingSpecification<Walls> walls;
        IBuildingSpecification<Roof> roof;

        public HouseSpecification(string address, IBuildingSpecification<Floor> floor, IBuildingSpecification<Walls> walls, IBuildingSpecification<Roof> roof)
        {
            this.address = address;
            this.floor = floor;
            this.walls = walls;
            this.roof = roof;
        }

        public static IHouseSpecification Initialize()
        {
            return new HouseSpecification("", null, null, null);
        }

        public IHouseWithAddressSpecification WithAddress(string address)
        {
            return new HouseSpecification(address,
                                          this.floor,
                                          this.walls,
                                          this.roof);
        }

        public IHousewithFloorSpecification WithFloor(IBuildingSpecification<Floor> floor)
        {
            return new HouseSpecification(this.address,
                                          floor,
                                          this.walls,
                                          this.roof);
        }

        public IHousewithWallsSpecification WithWalls(IBuildingSpecification<Walls> walls)
        {
            return new HouseSpecification(this.address,
                                          this.floor,
                                          walls,
                                          this.roof);
        }

        public IHouseWithRoofSpecification WithRoof(IBuildingSpecification<Roof> roof)
        {
            return new HouseSpecification(this.address,
                                          this.floor,
                                          this.walls,
                                          roof);
        }

        public IBuildingSpecification<House> Validate()
        {
            if (!(floor != null && walls != null && roof != null)
               || (floor != null && walls != null && roof == null)
               || (floor != null && walls == null && roof == null)
               || (floor == null && walls == null && roof == null))
                throw new ArgumentException("House is not valid!");

            return new HouseSpecification(this.address,
                                          this.floor,
                                          this.walls,
                                          this.roof);
        }

        public House Build()
        {
            return new House(this.address,
                             floor.Build(),
                             walls.Build(),
                             roof.Build());
        }

    }
}
