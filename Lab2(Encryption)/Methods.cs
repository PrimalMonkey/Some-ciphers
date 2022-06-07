using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Encryption_
{
    class Methods
    {
        public static int freq(int[] arr, int value)
        {
            int count = 0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
