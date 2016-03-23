using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_CakeTycoon
{
    class Cake_Tycoon
    {
        static void Main(string[] args)
        {
            ulong cakesWanted = ulong.Parse(Console.ReadLine());
            decimal kgForOneCake = decimal.Parse(Console.ReadLine());
            uint kgAvailable = uint.Parse(Console.ReadLine());
            uint truffles = uint.Parse(Console.ReadLine());
            uint price = uint.Parse(Console.ReadLine());
            decimal cakesToMake = Math.Floor((decimal)kgAvailable / kgForOneCake);
            //Console.WriteLine("Cakes to make {0}", cakesToMake);
            if (cakesToMake>=cakesWanted)
            {
                ulong trufflesCost = (ulong)truffles * (ulong)price;
                //Console.WriteLine("truffleCost {0}", trufflesCost);
                decimal cakePrice = ((decimal)trufflesCost / (decimal)cakesWanted) * 1.25m;
                //Console.WriteLine("cakePrice {0}", cakePrice);
                Console.WriteLine("All products available, price of a cake: {0:0.00}", cakePrice);
            }
            else
            {
                decimal totalFlour = cakesWanted * kgForOneCake;
                decimal kgNeeded = totalFlour - kgAvailable;
                Console.WriteLine("Can make only {0} cakes, need {1:0.00} kg more flour", cakesToMake, kgNeeded);
            }
        }
    }
}
