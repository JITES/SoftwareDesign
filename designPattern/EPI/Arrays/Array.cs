using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.EPI.Arrays
{
    class Array
    {
        public  void RearrangeArray()
        {
            int[] A = {3,5,6,1,10,22,7,8,2 };

            int next_even = 0, next_odd = A.Length - 1;

            while (next_even < next_odd)
            {
                if (A[next_even] % 2 == 0)
                {
                    ++next_even;
                }
                else
                {
                    //swap(A[next_even],A[next_odd--]);
                }
            }
        }
    }
}
