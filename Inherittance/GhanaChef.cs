using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherittance
{
    internal class GhanaChef
    {
        public void makeJellofRice()
        {
            Console.WriteLine("Makes jellof rice");
        }
        public void makePasta()
        {
            Console.WriteLine("make spagetti");
        }
        public virtual void makeSpecialDish()
        {
            Console.WriteLine( "Ofada rice and stew");
        }

    }
}
