using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves.TheDwarves
{
    internal class Grumpy : IDwarf
    {
        public void Appear()
        {
            throw new NotImplementedException();
        }

        public void CallNext()
        {
            throw new NotImplementedException();
        }

        public void Disappear()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Hi, I'm {this.GetType().Name}";
        }
    }
}
