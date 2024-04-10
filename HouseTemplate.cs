using System;

namespace lab10
{
    abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildWalls();
            AddSpecialFeature();
            AddRoof();
            Console.WriteLine("House is built.");
        }

        protected abstract void BuildFoundation();
        protected abstract void BuildWalls();
        protected virtual void AddRoof()
        {
            Console.WriteLine("Adding a standard roof.");
        }
        protected abstract void AddSpecialFeature();
    }
}
