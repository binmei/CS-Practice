using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePlays
{
    class Program
    {
        delegate int Add(int num1, int num2);

        static void Main(string[] args)
        {

            Add add1 = AddNow;
            Console.WriteLine(add1.Invoke(2, 2).ToString());
            Console.ReadKey();

            Add add2 = delegate (int num1, int num2)
            {
                return num1 + num2;
            };
            Console.WriteLine(add2.Invoke(3, 3).ToString());
            Console.ReadKey();
        }

        static int AddNow(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
