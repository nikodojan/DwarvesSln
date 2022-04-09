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
                    Console.WriteLine($"As Grumpy sees happy coming, he disappears.\r\n" +
                                      $"No one can handle that much happiness.");
                    SendAway(this);
                    Console.WriteLine($"Happy doesn't notice what just happened and is being happy.\r\n"); ;
                    CallNext();
                    break;
                case nameof(Sneezy):
                    Console.WriteLine($"Grumpy sees Sneezy sneeze. He hates it.");
                    CallNext();
                    break;
                case nameof(Dopey):
                    Console.WriteLine($"When Grumpy saw Dopey fooling around again, he gave him a headbutt.\r\n" +
                                      $"Dopey starts crying out loud.");
                    CallNext();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            
            nextDwarf.Act();
        }

        public override void Finish()
        {
            Console.WriteLine($"Grumpy got enough of the others and turns away mumbling in his beard.");
        }

    }
}
