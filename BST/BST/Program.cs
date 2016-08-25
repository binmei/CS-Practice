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

            //myTree.printTreeBFS();
            //Console.ReadKey();

            MyBST myTree2 = new BST.MyBST();
            myTree2.root = new BST.MyBST.Node(1);
            myTree2.root.left = new BST.MyBST.Node(2);
            myTree2.root.right = new BST.MyBST.Node(3);
            myTree2.root.left.left = new BST.MyBST.Node(4);
            myTree2.root.left.right = new BST.MyBST.Node(5);
            myTree2.root.right.left = new BST.MyBST.Node(6);
            myTree2.root.right.right = new BST.MyBST.Node(7);
            myTree2.size = 7;

            Console.WriteLine("Preorder Traversal: ");
            myTree2.PreorderTraversal(myTree2.root);
           
            Console.WriteLine("\n\nInorder Traversal: ");
            myTree2.InorderTraversal(myTree2.root);
            
            Console.WriteLine("\n\nPostorder Traversal: ");
            myTree2.PostorderTraversal(myTree2.root);

            //myTree2.add(26);
            //Console.WriteLine("\n\nInorder Traversal: ");
            //myTree2.InorderTraversal(myTree2.root);

            Console.WriteLine("\n\nBFS Traversal: ");
            myTree2.printTreeBFS();

            myTree2.size = 7;
            Console.WriteLine("\n\nDFS Traversal: ");
            myTree2.pirntTreeDFS();

            Console.ReadKey();

        }
    }
}
