using System;
using System.Collections.Generic;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rndList = new SimpleNumbers(1, 10);

            foreach (var item in rndList.simpleNumbers)
            {
                if (rndList.SimpleCheck())
                    Console.WriteLine(item);
                rndList.MoveNext();
            }
        }
    }
}
