using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    class AsQueryableMethod
    {
        static void Main()
        {
            var arr = new int[] { 100, 200, 300, 400 };
            int res = Queryable.Sum(arr.AsQueryable());
            Console.WriteLine("Sum will be : " + res);
        }
    }
}
