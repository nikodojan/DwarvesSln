using System;
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
                    Console.WriteLine($"Sneezy turned around and sneezed.\r\n" +
                                      $"Unluckily for Happy. He was in the way.");
                    CallNext();
                    break;
                case nameof(Grumpy):
                    Console.WriteLine($"Sneezy couldn't hold it an sneezed at Grumpy.\r\n");
                    Console.WriteLine($"Grumpy started cursing loudly while cleaning up himself."); ;
                    CallNext();
                    break;
                case nameof(Dopey):
                    Console.WriteLine($"Sneezy sneezes on dopey.\r\n" +
                                      $"Dopey finds it funny.");
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
                Console.WriteLine($"{Story.StoryFlow[index].GetType().Name} just shakes his head and goes away.");
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
            Console.WriteLine($"This whole story gives Sneezy a forceful allergy and he sneezes all over the other dwarves, who disperse in disgust.");
        }
    }
}
