using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyCollection
{
    class SimpleNumbers : IEnumerator
    {
        public List<int> simpleNumbers = new List<int>(10);
        int index = 0;
        public SimpleNumbers(int min, int max)
        {
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                simpleNumbers.Add(rnd.Next(min, max));               
            }
        }
        public int Current
        {
            get
            {
                return simpleNumbers[index];
            }
        }
        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (index <= 10)
            {
                index++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            index = 0;
        }
        public bool SimpleCheck()
        {
            bool check = true;
            for (int i = 2; i < Current; i++)
            {
                if ((Current % i) != 0)
                    check = true;
                else
                    return false;

            }
            return check;
        }
    }
}

