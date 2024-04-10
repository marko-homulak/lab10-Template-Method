using System;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseTemplate house1 = new MansardHouse();
            HouseTemplate house2 = new BalconyHouse();

            Console.WriteLine("Building a Mansard House:");
            house1.BuildHouse();

            Console.WriteLine("\nBuilding a House with a Balcony:");
            house2.BuildHouse();

            Console.Read();
        }
    }
}
