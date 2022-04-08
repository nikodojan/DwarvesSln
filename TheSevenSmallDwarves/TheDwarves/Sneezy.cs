using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    internal class Sneezy : DwarfBase
    {
        public override void Finish()
        {
            Console.WriteLine($"This whole story gives Sneezy a forceful allergy and he sneezes all over the other dwarves, who disperse in dusgust.");
        }
    }
}
