using System;

namespace lab10
{
    class BalconyHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building a standard foundation for the Balcony House.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building walls for the Balcony House.");
        }

        protected override void AddSpecialFeature()
        {
            Console.WriteLine("Adding a balcony to the house.");
        }
    }
}
