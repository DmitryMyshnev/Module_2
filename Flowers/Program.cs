using System;

namespace Flowers
{
    class Program
    {  
        static void Main(string[] args)
        {
            
            var bouquet = new Bouquet(7);
           
            Flower chamomile = new Flower("CHAMOMILE", 500);
            Flower chrysoneme = new Flower("CHRYSONEME", 600);
            Flower lily = new Flower("LILY", 450);
            Flower tulip = new Flower("TULIP", 800);
            Flower violet = new Flower("VIOLET", 750);

            bouquet[0] = chamomile;
            bouquet[1] = chamomile;
            bouquet[2] = chrysoneme;
            bouquet[3] = chrysoneme;
            bouquet[4] = chrysoneme;
            bouquet[5] = tulip;
            bouquet[6] = violet;

            int totalCost = bouquet.TotalCost();
            Console.WriteLine(bouquet.Length + "flowers");
            Console.WriteLine("Total cost: "+ totalCost);
            
        }
        
    }
}
