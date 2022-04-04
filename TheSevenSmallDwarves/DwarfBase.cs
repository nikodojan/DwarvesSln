using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSevenSmallDwarves
{
    public abstract class DwarfBase
    {
        //public abstract void Appear();
        //public abstract void CallNext();
        //public abstract void Disappear();
        public override string ToString() => $"Hi, I'm {this.GetType().Name}";
    }
}
