using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBST myTree = new BST.MyBST();
            myTree.add(5);
            myTree.add(3);
            myTree.add(1);
            myTree.add(2);
            myTree.add(4);
            myTree.add(6);
            myTree.add(9);
            myTree.add(7);
            myTree.add(8);
            myTree.add(10);
            myTree.add(12);

            myTree.printTreeBFS();
            Console.ReadKey();
        }
    }
}
