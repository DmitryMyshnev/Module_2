using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
   public class Lorry : Car

    {
        public int Capacity { get; set; }
        public Lorry(string manufacturer, int wight, int power, int capacity) : base(manufacturer, wight, power)
        {
            Capacity = capacity;
        }
        public   void ChengeCapacity(int capacity)
        {
           this.Capacity = capacity;
        }
        public  void CarInfo()
        {
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Wight: " + Wight);
            Console.WriteLine("Power: " + Power);
            Console.WriteLine("Capacity: " + Capacity);
        }
        public override void OverrideChangeCapacity(int capacity)
        {
            base.OverrideChangeCapacity(capacity);
            
        }

    }
}
