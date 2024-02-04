using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
     public static class ArrayExtension
    {
        public static void SumOfElements(this int[] a)
        {
            if (a.Length == 1)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a[0] + a[a.Length - 1]);
            }
        }
    }
}
