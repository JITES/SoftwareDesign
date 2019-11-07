using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace designPattern.program
{
    class Node
    {
        public int key;
        public Node(int key)
        {
            this.key = key;
        }

        public Node left = null;
        public Node right = null;
    }

    class Execute
    {
        static void MainD()
        {
            Node node = new Node(10);
            node.left = new Node(5);
            node.left.left = new Node(7);
            node.left.right = new Node(11);
            node.right = new Node(6);
            node.right.left = new Node(16);
            node.right.right = new Node(21);

            BinaryTree b = new BinaryTree();
            //  var response = b.FindElement(node,21);
            var insert = b.InsertElemet(node, 55);
            var res = b.InorderTraversal(node);
        }
    }

    class BinaryTree
    {
        public IList<int> InorderTraversal(Node root)
        {
            var temp = new List<int>();

            if (root == null)
            {
                return null;
            }

            {
                InorderTraversal(root.left );
                temp.Add(root.key );
                Console.Write(root.key + " ");
                InorderTraversal(root.right);
            }

            return temp;
        }

        public bool InsertElemet(Node node, int newElement)
        {
            if (node == null)
            {
                return false;
            }

            if (node.left == null)
            {
                node.left = new Node(newElement);
                return true;
            }
            else
            {
                if (node.right == null)
                {
                    node.left = new Node(newElement);
                    return true;

                }
                else
                {
                    bool temp = InsertElemet(node.left, newElement);
                    if (!temp)
                    {
                        return InsertElemet(node.right, newElement);
                    }
                    return temp;
                }
            }
        }

        void Que()
        {
        Queue m = new Queue();

        }


        public bool FindElement(Node node, int element)
        {
            if (node == null)
            {
                return false;
            }

            else
            {
                if (element == node.key)
                {
                    return true;
                }
                else
                {
                    bool temp;
                    temp = FindElement(node.left, element);
                    if (temp)
                    {
                        return temp;
                    }
                    else
                    {
                        return FindElement(node.right, element);
                    }
                    //? true : FindElement(node.right, element);
                    
                }
            }
            return false;
        }

        public int MaxElement(Node node)
        {
            int root, left, right, max = 0;
            if (node!= null)
            {
                root = node.key;
                left = MaxElement(node.left);
                right = MaxElement(node.right);

                if (left>right)
                {
                    max = left;
                }
                max = right;

                if (root > max)
                {
                    max = root;
                }
            }
            return max;
        }
    }
}
