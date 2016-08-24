using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrTester
{
    class Program
    {
        static int N;
        static int G;
        static int lastAns = 0;

        static void Main(string[] args)
        {
            ArrayList seqList = new ArrayList();
        }

        static int Query1(int x, int y, int lastAns)
        {
            return (x ^ lastAns) % N;
        }

        static int Query2(int x, int y, int lastAns)
        {
            return x + y;
        }
    }
}
