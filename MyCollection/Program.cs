using System;
using System.Collections.Generic;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranList = new SimpleNumbers(1, 10);

            foreach (var item in ranList.simpleNumbers)
            {
                if (ranList.SimpleCheck())
                    Console.WriteLine(item);
                ranList.MoveNext();
            }
        }
    }
}
