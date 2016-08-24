using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class MyBST
    {
        public class Node
        {
            public Node left = null;
            public Node right = null;
            public int data;

            public Node(int d)
            {
                this.data = d;
            }
        }

        public Node root, curr;
        public int size = 0;

        public void add(int num)
        {
            Node newNode = new Node(num);
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                curr = root;
                while (curr!=null)
                {
                    Node tempParent = curr;
                    if (num < curr.data)
                    {
                        curr = curr.left;
                        if(curr == null)
                        {
                            tempParent.left = newNode;
                            size++;
                        }
                    }
                    else
                    {
                        curr = curr.right;
                        if(curr == null)
                        {
                            tempParent.right = newNode;
                            size++;
                        }
                    }
                }
            }
        }

        public void PostorderTraversal(Node current)
        {
            if (current != null)
            {
                // Recursively print the left and right children
                PreorderTraversal(current.left);
                PreorderTraversal(current.right);

                // Output the value of the current node
                Console.WriteLine(current.data);
            }
        }

        public void PreorderTraversal(Node current)
        {
            if (current != null)
            {
                // Output the value of the current node
                Console.WriteLine(current.data);

                // Recursively print the left and right children
                PreorderTraversal(current.left);
                PreorderTraversal(current.right);
            }
        }

        public void InorderTraversal(Node current)
        {
            if (current != null)
            {
                // Visit the left child...
                InorderTraversal(current.left);

                // Output the value of the current node
                Console.WriteLine(current.data);

                // Visit the right child...
                InorderTraversal(current.right);
            }
        }

        public void printTreeBFS()
        {
            Queue<int> q = new Queue<int>();
            if (this.root != null)
            {
                q.Enqueue(root.data);
            }
            while (this.size >= 0)
            {
                int tempNum = q.Dequeue();
                Console.Write(tempNum);
                if (root.left != null)
                {
                    q.Enqueue(root.left.data);
                }
                else if(root.right != null)
                {
                    q.Enqueue(root.right.data);
                }
            }
        }
    }


}
