using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Cars
{
    class BuickLacrosse : Car
    {
        public bool isLuxury { get; set; } = true;
        public string Name { get; set; }

        public BuickLacrosse()
        {
            Name = "Buick Lacrosse";
        }

    }
}
