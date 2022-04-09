﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    internal class Sneezy : DwarfBase
    {
        public override void React()
        {
            DwarfBase nextDwarf = Story.StoryFlow[Story.StoryFlow.IndexOf(this) + 1];

            switch (nextDwarf.GetType().Name)
            {
                case nameof(Happy):
                    //Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    Console.WriteLine($"Sneezy turned around and sneezed.\r\n" +
                                      $"Unluckily for Happy. He was in the way.");
                    CallNext($"Next dwarf: {nextDwarf}");
                    break;
                case nameof(Grumpy):
                    //Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    Console.WriteLine($"Sneezy couldn't hold it an sneezed at Grumpy.\r\n");
                    CallNext($"Grumpy started cursing loudly while cleaning up himself.");
                    break;
                case nameof(Dopey):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    CallNext($"Next dwarf: {nextDwarf}");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            
            nextDwarf.Act();
        }

        public override void Finish()
        {
            Console.WriteLine($"This whole story gives Sneezy a forceful allergy and he sneezes all over the other dwarves, who disperse in disgust.");
        }
    }
}
