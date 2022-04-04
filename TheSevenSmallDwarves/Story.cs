using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves
{
    internal class Story
    {
        public List<IDwarf> Dwarves { get; set; }

        public List<IDwarf> StoryList { get; set; }

        public Story()
        {
            Dwarves = new List<IDwarf>();
            CreateDwarves();
        }

        private void CreateDwarves()
        {
            string ns = "TheSevenSmallDwarves.TheDwarves";
            var dwarfTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.Namespace == ns);

            List<IDwarf> dwarves = new ();

            foreach (var type in dwarfTypes)
            {
                var dwarf = Activator.CreateInstance(type);
                dwarves.Add(dwarf as IDwarf);
            }

            Random rnd = new Random();

            while (dwarves.Any())
            {
                var i = rnd.Next(0, dwarves.Count);
                Dwarves.Add(dwarves[i]);
                dwarves.RemoveAt(i);
            }
        }
    }
}
