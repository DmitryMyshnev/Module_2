using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    class Flower 
    {
        internal string Name { get; set; }
        internal int Cost { get; set; }
       
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Flower(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
            
        }
    }
}
