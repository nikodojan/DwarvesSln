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
                    Console.WriteLine($"Happy might be the only one to understand what Dopey says.\r\n" +
                                      $"They starts a little small talk.");
                    CallNext();
                    break;
                case nameof(Grumpy):
                    Console.WriteLine($"Before Grumpy comes, Dopey runs away.\r\n" +
                                      $"He can be really mean sometimes.");
                    SendAway(this);
                    CallNext();
                    break;
                case nameof(Sneezy):
                    Console.WriteLine($"Dopey finds it funny when Sneezy sneezes.\r\n" +
                                      $"He runs after him the whole time.");
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
            Console.WriteLine($"Dopey doesn't care about all that. He is dopey.");
        }
    }
}
