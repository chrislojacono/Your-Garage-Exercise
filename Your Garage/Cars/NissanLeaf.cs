using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class NissanLeaf : Car
    {
        public bool Electric { get; set; }
        public bool SelfParking { get; set; }
        public string Name { get; }
        public NissanLeaf(bool electric)
        {
            Name = "Nissan Leaf";
            Electric = electric;
        }
    }
}
