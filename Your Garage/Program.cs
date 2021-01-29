using System;
using System.Collections.Generic;
using Your_Garage.Aircrafts;
using Your_Garage.Cars;
using Your_Garage.Watercrafts;

namespace Your_Garage
{
    class Program
    {
        public static void Main()
        {
            var myJet = new Jet();
            var airCraftCollection = new List<Aircraft> {new TiltRotor(2), myJet };
            foreach (var aircraft in airCraftCollection)
            {
                aircraft.Flying();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var carCollection = new List<Car> { new BuickLacrosse(), new NissanLeaf(true)};
            foreach (var car in carCollection)
            {
                car.Driving();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waterCraftCollection = new List<Watercraft> { new SwampBoat(), new FishingBoat(false) };
            foreach (var waterCraft in waterCraftCollection)
            {
                waterCraft.Driving();
            }
        }
    }
}
