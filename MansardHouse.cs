using System;

namespace lab10
{
    class MansardHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building a strong foundation for the Mansard House.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building walls for the Mansard House.");
        }

        protected override void AddSpecialFeature()
        {
            Console.WriteLine("Adding a Mansard to the house.");
        }

        protected override void AddRoof()
        {
            Console.WriteLine("Adding a unique sloped roof for the Mansard House.");
        }
    }
}
