using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
   internal class Tulip : ICloneable
    {
        internal string Name { get; set; }
        internal int Cost { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Tulip(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
