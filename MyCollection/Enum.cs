using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollection
{
    class Enum :IEnumerator
    {

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
