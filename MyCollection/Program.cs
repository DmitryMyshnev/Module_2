using System;
using System.Collections.Generic;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rndList = new SimpleNumbers(1, 30);
            int count = 0;
            foreach (var item in rndList)
            {
                if (rndList.SimpleCheck(count))
                    Console.WriteLine(item);
                count++;
            }
            Console.ReadLine();
        }
    }
}
