using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Aircrafts
{
    class Jet : Aircraft
    {
        public override void Flying()
        {
            Console.WriteLine("You're flying in style! Business class!!");
        }
    }
}
