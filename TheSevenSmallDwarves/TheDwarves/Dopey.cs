using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    internal class Dopey : DwarfBase
    {
        public override void React()
        {
            DwarfBase nextDwarf = Story.StoryFlow[Story.StoryFlow.IndexOf(this) + 1];

            switch (nextDwarf.GetType().Name)
            {
                case nameof(Happy):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    CallNext($"NEEEXT");
                    break;
                case nameof(Grumpy):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    CallNext($"NEEEXT");
                    break;
                case nameof(Sneezy):
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
            Console.WriteLine($"Dopey doesn't care about all that. He is dopey.");
        }
    }
}
