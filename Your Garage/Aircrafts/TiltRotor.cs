using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Aircrafts
{
    class TiltRotor : Aircraft
    {
        public int NumberOfRotors { get; set; }

        public TiltRotor(int numOfRotors)
        {
            NumberOfRotors = numOfRotors;
        }
        public override void Flying()
        {
            if(NumberOfRotors > 2)
            {
                Console.WriteLine("Get to the CHOPPPPAAAAA!!!");
            }
            else
            {
             base.Flying();
            }
           
        }
    }
}
