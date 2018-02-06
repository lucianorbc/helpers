using System;
using BuilderPattern;

namespace SpecificationPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Specification Demo\n\n\n");

            House house = HouseSpecification.Initialize()
                                            .WithAddress("5th Av, New York")
                                            .WithFloor(FloorSpecification.Initialize()
                                                       .WithTiles(12))
                                            .WithWalls(WallsSpecification.Initialize()
                                                       .WithWindows(12))
                                            .WithRoof(RoofSpecification.Initialize()
                                                      .HasRoofTiles(12)
                                                      .HasColor("Red"))
                                            .Validate()
                                            .Build();

            Console.WriteLine($"We just built an house! {house.ToString()}");
        }
    }
}
