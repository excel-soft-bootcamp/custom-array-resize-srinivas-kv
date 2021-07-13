using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Array
{
    class Array
    {
        public static void Resize(ref int[] arrayRef, int reSize)
        {
            int[] newArray = new int[reSize];
            for (int i = 0; i < arrayRef.Length; i++)
            {
                newArray[i] = arrayRef[i];
            }
            arrayRef = newArray;
            
        }
    }
}
