using System;

namespace Flowers
{
    class Program
    {
        static Bouquet assortment = new Bouquet(5);
        static int indexOfAssortment ;
        static bool CheckMistake(string inputText)
        {
            bool statusOfSearch = false;
            if (String.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("Incorrect input");
                return statusOfSearch;
            }
            // inputText = inputText.ToUpper();
            for (int i = 0; i < assortment.arrLength; i++)
            {
                if (inputText.StartsWith(assortment[i].Name))
                {
                    statusOfSearch = true;
                    indexOfAssortment = i;
                    break;
                }
                else
                    statusOfSearch = false;
            }

            if (inputText == "STOP")
                return statusOfSearch = true;

            if (!statusOfSearch)
            {
                Console.WriteLine("Not found flowers");
            }
            string[] text = inputText.Split(',');
            if (text.Length < 2)
            {
                statusOfSearch = false;
                Console.WriteLine("Incorrect input");
            }
            else
            {
                int.TryParse(text[1], out int quantity);
                if (quantity == 0)
                {
                    statusOfSearch = false;
                    Console.WriteLine("Incorrect  input quantity");
                }
            }
            return statusOfSearch;
        }
        static void Main(string[] args)
        {
            
            var range = new Bouquet(5);
            string yourChoice = null;
            Flower chamomile = new Flower("CHAMOMILE", 500);
            Flower chrysoneme = new Flower("CHRYSONEME", 600);
            Flower lily = new Flower("LILY", 450);
            Flower tulip = new Flower("TULIP", 800);
            Flower violet = new Flower("VIOLET", 750);

            assortment[0] = chamomile;
            assortment[1] = chrysoneme;
            assortment[2] = lily;
            assortment[3] = tulip;
            assortment[4] = violet;
            
            for (int i = 0; i < range.assortment.Length; i++)
            {
                Console.WriteLine(assortment[i].Name + ": " + assortment[i].Cost + ",grn");
            }
            Console.WriteLine("");
            Console.WriteLine("Choice flowers in format: 'Name of flower','quantity'. For example: Tulip,3 ");
            string choice;
            int quantity = 0;
            choice = Console.ReadLine();
            choice = choice.ToUpper();
           
            while (choice != "STOP")
            {                         
                while (!CheckMistake(choice))
                {
                    choice = Console.ReadLine();
                }
                string[] text = choice.Split(',');
                int.TryParse(text[1], out int count);
                quantity += count;
                yourChoice += (choice + ",");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
            }
            var bouquets = new Bouquet(quantity);
            string[] s;
            s = yourChoice.Split(',');
            for (int i = 0,j=0; i < s.Length; i++)
            {
                if (s[i] == assortment[j].Name)
                    bouquets[0] = assortment[j];
                else
                    j++;
            } 
            
            
            //foreach (var item in Bouquet)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine("Total cost : " + TotalCost());
            //Console.WriteLine("Count: " + Bouquet.Length);
        }
        
    }
}
