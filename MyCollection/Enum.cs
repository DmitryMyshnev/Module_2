using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace MyCollection
{
    class Enum : IEnumerator
    {
        private int index = -1;
        private int[] data;
        public Enum(int[] input)
        {
            this.data = input;
        }

        public int Index
        {
            get
            {
                return index;
            }
        }
        object IEnumerator.Current 
        {
            get
            {
                if (index == -1 || index >= data.Length)
                {
                    throw new Exception();
                }              
                    return data[index];
            }
        }
  
        public bool MoveNext()
        {
            if (index < data.Length-1)
            {
                index++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
