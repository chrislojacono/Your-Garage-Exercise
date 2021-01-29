using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Watercrafts
{
    class SwampBoat : Watercraft
    {
        public int TopSpeed { get; set; }
        

        public override void Driving()
        {
            Console.WriteLine($"Try Not to hit any gaitors in the boat!");
        }
    }
}
