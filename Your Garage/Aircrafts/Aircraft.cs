using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Aircraft : Vehicle
    {
        public virtual void Flying()
        {
            Console.WriteLine("Fly like a bird!");
        }
        public virtual void Landing()
        {
            Console.WriteLine("Everyone hold on, We are landing!");
        }
    }
}
