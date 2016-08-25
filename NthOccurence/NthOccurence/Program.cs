using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Big apple Big banana Big peach Big click";
            string match = "Big";
            int occ = 5;
            int index = IndexOfOccurence(str, match, occ);
            Console.WriteLine(index);
            Console.ReadKey();
        }

        public static int IndexOfOccurence(string str, string subStr, int occurence)
        {
            int i = 1;
            int index = -1;
            if (str == null || subStr == null || str.Length <= 0 || subStr.Length <= 0)
            {
                return -1;
            }

            while (i <= occurence && (index = str.IndexOf(subStr, index + 1)) != -1)
            {
                if (i == occurence)
                {
                    return index;
                }                
                i++;
            }
            return -1;
        }
    }
}
