using System;
using MyClassLibrary;

namespace WOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank t34 = new Tank("T-34");
            Tank pantera = new Tank("Pantera");
            Tank winnerTank = t34 ^ pantera;
            winnerTank.GetInfo(winnerTank);
            Console.ReadLine();

        }
    }
}
