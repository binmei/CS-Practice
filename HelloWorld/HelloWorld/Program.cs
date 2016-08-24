using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };

            var numQuery =
                from n in num
                where (n % 2) == 0
                select n;

            foreach(int n in numQuery)
            {
                Console.Write("{0,1} ", n);
            }

            Console.Read();

            LinkedList<int> theList = new LinkedList<int>();
            for(int i = 0; i < 50; i++)
            {
                theList.AddLast(i);
            }

            var numQuery2 =
                select n2
                from n2 in theList
                where (n2 % 2) == 0;

            foreach (int n in numQuery2)
            {
                Console.Write("{0,1} ", n);
            }

            Console.ReadKey();

        }
    }
}
