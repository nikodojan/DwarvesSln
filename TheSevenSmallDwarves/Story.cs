using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves
{
    public class Story
    {
        public List<DwarfBase> Dwarves { get; set; }
        public List<DwarfBase> StoryFlow { get; set; } = new();

        public Story()
        {
            Dwarves = new List<DwarfBase>();
            CreateDwarves();
        }

        public void Run()
        {
            StoryFlow = Dwarves.Take(2).ToList();
            Dwarves.RemoveRange(0,2);
            StoryFlow[0].Act();
        }

        private void CreateDwarves()
        {
            string ns = "TheSevenSmallDwarves.TheDwarves";
            var dwarfTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.Namespace == ns);

            List<DwarfBase> dwarves = new ();

            foreach (var type in dwarfTypes)
            {
                var dwarf = Activator.CreateInstance(type);
                dwarves.Add(dwarf as DwarfBase);
            }

            Random rnd = new Random();

            while (dwarves.Any())
            {
                var i = rnd.Next(0, dwarves.Count);
                dwarves[i].Story = this;
                Dwarves.Add(dwarves[i]);
                dwarves.RemoveAt(i);
            }
        }
    }
}
