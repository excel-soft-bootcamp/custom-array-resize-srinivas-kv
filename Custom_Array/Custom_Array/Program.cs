using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[2];
            value[0] = 10;
            value[1] = 20;
            Array.Resize(ref value, value.Length + 2);
            value[2] = 30;
            value[3] = 40;
            Array.Resize(ref value, value.Length + 2);
            value[4] = 50;
            value[5] = 60;
            Array.Resize(ref value, value.Length + 2);
            value[6] = 70;
            value[7] = 80;
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);
            }
            Console.ReadKey();
        }
    }
}
