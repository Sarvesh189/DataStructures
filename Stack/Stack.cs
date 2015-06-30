using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class Stack
    {
        int[] itemCollection = new int[5];
        int index = -1;

        public void Push(int item)
        {
            index++;
            itemCollection[index]=item;
        }

        public  IEnumerable<int> Pop()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return itemCollection[i];
            }
        }
    }


}
