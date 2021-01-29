using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Watercrafts
{
    class FishingBoat : Watercraft
    {
        public int FeetLong { get; set; }
        public bool HasSails { get; set; }

        public FishingBoat(bool hasSails)
        {
            HasSails = hasSails;
        }
    }
}
