using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{

    public class Grumpy : DwarfBase
    {
        public override void React()
        {
            DwarfBase nextDwarf = Story.StoryFlow[Story.StoryFlow.IndexOf(this) + 1];

            switch (nextDwarf.GetType().Name)
            {
                case nameof(Happy):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    Console.WriteLine($"As Grumpy sees happy coming, he disappers.\r\n" +
                                      $"No one can handle that much happiness");
                    SendAway(this);
                    CallNext($"Happy doesn't notice what just happened and is being happy.");
                    break;
                case nameof(Sneezy):
                    Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    CallNext($"NEEEXT");
                    break;
                case nameof(Dopey):
                    //Console.WriteLine($"Switch: I am {this.GetType().Name}. I react on {nextDwarf.GetType().Name}");
                    Console.WriteLine($"When Grumpy saw Dopey fooling around again, he gave him a headbutt.");
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
            Console.WriteLine($"Grumpy got enough of the others and walks away mumbling in his beard.");
        }

    }
}
