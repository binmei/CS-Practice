using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> theList = new List<int>();
            HashSet<int> hs = new HashSet<int>(arr);
            foreach(int i in arr2){
                if(hs.Add(i) == false)
                {
                    theList.Add(i);
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
