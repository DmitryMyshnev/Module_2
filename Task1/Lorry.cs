using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Lorry : Car

    {
        public int Capacity { get; set; }
        public Lorry(string manufacturer, int wight, int power, int capacity) : base(manufacturer, wight, power)
        {
            Capacity = capacity;
        }
        public void ChengeCapacity(int capacity)
        {
            Capacity = capacity;
        }
        public override void CarInfo()
        {
            base.CarInfo();
            Console.WriteLine("Capacity: " + Capacity);
        }

    }
}
