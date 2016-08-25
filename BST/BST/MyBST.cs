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

        public bool delete(int num)
        {
            if (root == null)
            {
                return false;
            }
            //case 1: no child
            //          set parent.left || parent.right == null
            //case 2: one child
            //          parent.left == child || parent.right == child
            //case 3: two children
            //          parent.right == minimum of right tree

            return false;
        }


        public void PreorderTraversal(Node current)
        {
            if (current != null)
            {
                Console.Write(current.data + " ");
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
                Console.Write(current.data + " ");

                // Visit the right child...
                InorderTraversal(current.right);
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
                Console.Write(current.data + " ");
            }
        }

        public void printTreeBFS()
        {
            Queue<Node> q = new Queue<Node>();
            if (this.root != null)
            {
                q.Enqueue(root);
            }
            while (this.size > 0)
            {
                Node tempNode = q.Dequeue();
                Console.Write("{0} ", tempNode.data);
                this.size--;
                if (tempNode.left != null)
                {
                    q.Enqueue(tempNode.left);
                }
                if(tempNode.right != null)
                {
                    q.Enqueue(tempNode.right);
                }
            }
        }

        public void pirntTreeDFS()
        {
            Stack<Node> s = new Stack<Node>();
            if (this.root != null)
            {
                s.Push(root);
            }
            while (this.size > 0)
            {
                Node tempNode = s.Pop();
                Console.Write("{0} ", tempNode.data);
                this.size--;
                if (tempNode.right != null)
                {
                    s.Push(tempNode.right);
                }
                if (tempNode.left != null)
                {
                    s.Push(tempNode.left);
                }
            }
        }
    }


}
