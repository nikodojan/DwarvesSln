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
            Console.WriteLine($"[{string.Join(", ", Story.StoryFlow)}]\r\n");
            if (IsLast)
            {
                Finish();
            }
            else
            {
                React();
            }
        }

        public abstract void React();

        public void CallNext(string? text = null, DwarfBase? next = null)
        {
            if (next is null && Story.Dwarves.Any())
            {
                Story.StoryFlow.Add(Story.Dwarves[0]);
                Story.Dwarves.RemoveAt(0);
            }
            Console.WriteLine(text);
        }

        public virtual void SendAway(DwarfBase dwarf)
        {
            Story.StoryFlow.Remove(dwarf);
        }

        public abstract void Finish();

        public override string ToString() => this.GetType().Name;
    }
}
