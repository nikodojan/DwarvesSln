﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    public class Happy : DwarfBase
    {
        public override void React()
        {
            DwarfBase nextDwarf = Story.StoryFlow[Story.StoryFlow.IndexOf(this) + 1];

            switch (nextDwarf.GetType().Name)
            {
                case nameof(Sneezy):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    CallNext($"NEEEXT");
                    break;
                case nameof(Grumpy):
                    //Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    Console.WriteLine($"Happy tries to make Grumpy a little less Grumpy by telling him a joke.\r\n");
                    CallNext($"NEEEXT");
                    break;
                case nameof(Dopey):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    CallNext($"NEEEXT");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            nextDwarf.Act();
        }
        public override void Finish()
        {
            Console.WriteLine($"Happy starts dancing with his friends. Spreading happiness is his mission.");
        }


    }
}