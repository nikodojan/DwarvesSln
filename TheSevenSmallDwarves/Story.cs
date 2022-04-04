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

        public Story()
        {
            Dwarves = new List<IDwarf>();
            CreateDwarves();
        }

        private void CreateDwarves()
        {
            string ns = "TheSevenSmallDwarves.TheDwarves";
            var d = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.Namespace == ns);

            foreach (var type in d)
            {
                var dw = Activator.CreateInstance(type);
                Dwarves.Add(dw as IDwarf);
            }
        }
    }
}
