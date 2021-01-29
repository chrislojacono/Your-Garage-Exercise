using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Aircraft : Vehicle
    {
        public void Flying()
        {
            Console.WriteLine("Fly like a bird!");
        }
        public void Landing()
        {
            Console.WriteLine("Everyone hold on, We are landing!");
        }
    }
}
