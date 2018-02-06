using System;

namespace BuilderPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Builder Demo\n\n\n");

            House house = HouseBuilder
                .Init()
                .AddFloor()
                .AddWalls()
                .AddRoof()
                .Build();
            
            Console.WriteLine($"We just built an house! {house.ToString()}");
        }
    }
}
