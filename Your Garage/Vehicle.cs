using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Vehicle
    {
        public string FuelCapacity { get; set; } = "50 gallons";
        public string Color { get; set; } = "Black";
        public int PassengerOccupancy { get; set; } = 4;
        
        public  virtual void Refueling()
        {
            Console.WriteLine($"Pull up the {PassengerOccupancy} {GetType().Name} and fill up the tank.");
        } 
        public virtual void Driving()
        {
            Console.WriteLine($"Driiiiivvvveeee!!!");
        }
    }
}
