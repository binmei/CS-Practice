using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPlays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var num = 
                from k in arr
                where (k / 6) == 1
                select k;

            foreach(int n in num)
            {
                Console.Write("{0} ", n);
            }
            Console.ReadKey();
        }
    }
}
