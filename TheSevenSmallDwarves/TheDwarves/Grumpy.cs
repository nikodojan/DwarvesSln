using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    public class Grumpy : DwarfBase
    {
        public override void Finish()
        {
            Console.WriteLine($"{this.GetType().Name} is last in list.");
        }

    }
}
