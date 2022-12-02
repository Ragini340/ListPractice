using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class AnyMethod
    {
        static void Main()
        {
            int[] arr = { 5, 7, 10, 12, 15, 18, 20 };

            // Here hecking if any of the array elements are greater than 10
            bool res = arr.AsQueryable().Any(val => val > 10);
            Console.WriteLine(res);
        }
    }
}

