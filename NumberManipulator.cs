using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_classes
{
    class NumberManipulator
    {
       public int FindMax(int first, int second)
        {
            int result; //Здесь хранится наибольшее число

            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
    }
}
