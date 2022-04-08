using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves
{
    public abstract class DwarfBase
    {
        public bool IsLast => !Story.Dwarves.Any() && Story.StoryFlow.Last() == this;
        public Story Story { get; set; }

        public void Act()
        {
            if (IsLast)
            {
                Finish();
            }
            else
            {
                React();
            }
        }

        public void React()
        {
            Console.WriteLine($"I am {this.GetType().Name}. I react on {Story.StoryFlow[Story.StoryFlow.IndexOf(this)+1].GetType().Name}");
            CallNext();

        }

        public void CallNext(DwarfBase? next = null)
        {
            if (next is null && Story.Dwarves.Any())
            {
                Story.StoryFlow.Add(Story.Dwarves[0]);
                Story.Dwarves.RemoveAt(0);
            }

            Story.StoryFlow[Story.StoryFlow.IndexOf(this) + 1].Act();
        }

        public void SendAway(DwarfBase? dwarf = null)
        {
            if (Story.StoryFlow.Contains(dwarf))
                Story.StoryFlow.Remove(dwarf);
        }

        public abstract void Finish();


        public override string ToString() => $"Hi, I'm {this.GetType().Name}";
    }
}
