using System;

namespace Task1
{
    
    class Program 
    {
        static void Main(string[] args)
        {
             var lorry = new Lorry("BMW", 1500,200,2000);       
             lorry.ChangePower(210);
             lorry.CarInfo();
             lorry.ChengeCapacity(140);
             lorry.OverrideChangeCapacity(100);
             lorry.CarInfo();
           
        }
    }
}
