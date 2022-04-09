using System;
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
                    Console.WriteLine($"Happy greets Sneezy with a spirited clap on the back," +
                                      $"which triggers an allergic reaction.");
                    CallNext();
                    break;
                case nameof(Grumpy):
                    Console.WriteLine($"Happy tries to make Grumpy a little less Grumpy by telling him a joke.\r\n" +
                                      $"As if that ever worked.");
                    CallNext();
                    break;
                case nameof(Dopey):
                    Console.WriteLine($"Happy and Dopey start fooling around.\r\n" +
                                      $"Why not just have some fun?");
                    SendAway();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            nextDwarf.Act();
        }

        public override void SendAway(DwarfBase? dwarf = null)
        {
            DwarfBase nextDwarf = Story.StoryFlow[Story.StoryFlow.IndexOf(this) + 1];

            int index = Story.StoryFlow.IndexOf(this) - 1;
            if (index >= 0)
            {
                Console.WriteLine($"{Story.StoryFlow[index].GetType().Name} is afraid of getting hurt and leaves to be save.");
                CallNext();
                Story.StoryFlow.RemoveAt(index);

            }
            else
            {
                CallNext();
            }
        }

        public override void Finish()
        {
            Console.WriteLine($"In the end Happy starts dancing with his friends. Spreading happiness is his mission.");
        }


    }
}
