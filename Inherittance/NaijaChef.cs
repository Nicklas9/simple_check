using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherittance
{
    internal class NaijaChef : GhanaChef
    {
        public override void makeSpecialDish()
        {
            Console.WriteLine("chicken and chips");
        }

        public void makeSuya()
        {
            Console.WriteLine("make suya and killishi");
        }
        
    }
    
}
