using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
   public  class Car
    {
        public string Manufacturer { get; set; }
        public int Wight { get; set; }
        public int Power { get; set; }
        public Car(string manufacturer, int wight, int power)
        {
            this.Manufacturer = manufacturer;
            this.Wight = wight;
            this.Power = power;
        }
        public void ChangePower(int power)
        {
            this.Power = power;
        }

                    
    }
}
