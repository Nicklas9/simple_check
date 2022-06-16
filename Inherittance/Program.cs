using System;

namespace Inherittance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GhanaChef ghanaChef = new GhanaChef();
            ghanaChef.makePasta();


            NaijaChef naijaChef = new NaijaChef();
            naijaChef.makePasta();
            naijaChef.makeSuya();
            naijaChef.makeJellofRice();

        }
    }
}
