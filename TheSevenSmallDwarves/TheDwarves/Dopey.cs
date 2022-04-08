using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    internal class Dopey : DwarfBase
    {
        public override void Finish()
        {
            Console.WriteLine($"Dopey starts fooling around with the others.");
        }
    }
}
