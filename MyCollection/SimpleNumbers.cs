using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyCollection
{
  public  class SimpleNumbers : IEnumerable
    {
       // public List<int> simpleNumbers = new List<int>(10);
        private int[] simpleNum;  
        
        public SimpleNumbers(int min, int max)
        {
            simpleNum = new int[10];
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.simpleNum[i] = (rnd.Next(min, max));               
            }
         
        }     

        public IEnumerator GetEnumerator()
        {
            return new Enum(simpleNum);
        }
 
        public bool SimpleCheck(int count)
        {          
            bool check = true;
            for (int i = 2; i < simpleNum[count]; i++)
            {
                if ((simpleNum[count] % i) != 0)
                    check = true;
                else
                    return false;
            }
            return check;
        }
    }
}

