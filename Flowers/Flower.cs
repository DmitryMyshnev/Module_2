using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    class Flower 
    {
        internal string Name { get; set; }
        internal int Cost { get; set; }
       
        public Flower(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
            
        }
    }
}
