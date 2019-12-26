using System;

namespace Flowers
{
    class Program
    {
        static Tulip[] Bouquet = new Tulip[7];
        static int CostTogether()
        {
            int cost = 0;
            for (int i = 0; i < Bouquet.Length; i++)
            {
                cost += Bouquet[i].Cost;
            }
            return cost;
        }
        static void Main(string[] args)
        {
           
            Tulip RubyRed = new Tulip("Ruby Red",500);
            Tulip PrinceOfAustria = new Tulip("Prince of Austria",600);
            Tulip PrinsCarnaval = new Tulip("Prins Carnaval",450);
            Tulip PinkTrophy = new Tulip("Pink Trophy",800);
            Tulip Flair = new Tulip("Flair",750);
          
            Bouquet[0] = (Tulip)RubyRed.Clone();
            Bouquet[1] = (Tulip)PrinceOfAustria.Clone();
            Bouquet[2] = (Tulip)PrinceOfAustria.Clone();
            Bouquet[3] = (Tulip)PinkTrophy.Clone();
            Bouquet[4] = (Tulip)Flair.Clone();
            Bouquet[5] = (Tulip)Flair.Clone();
            Bouquet[6] = (Tulip)Flair.Clone();

            Console.WriteLine("Your bouquet:");
            foreach (var item in Bouquet)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Cost tugeser: " + CostTogether());
            Console.WriteLine("Count: " + Bouquet.Length);
        }
        
    }
}
