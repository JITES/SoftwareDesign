using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.program
{
    class rotateArray
    {
        static void RightRotate(int[] arr, int d, int n)
        {
            for (int i = 0; i < d; i++)
            {
                RightRotateByOne(arr, arr.Length);
            }
        }

        private static void RightRotateByOne(int[] arr, int n)
        {
            int last = arr[arr.Length - 1];
            int i, temp = arr[0];
            for (i = arr.Length-1; i > 0; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[0] = last;
        }

       // static void Main() => LeftRotate(new int[] { 1,2,3,4,5 }, 2, 4);

        private static void LeftRotate(int[] v1, int v2, int v3)
        {
            for (int i = 0; i < v2; i++)
            {
                LeftRotateByOne(v1);
            }
        }

        private static void LeftRotateByOne(int[] v1)
        {
            int i,temp = v1[0];
            for (i = 0; i < v1.Length - 1; i++)
            {
                v1[i] = v1[i + 1];
            }

            v1[i] = temp;
        }

        private static int HeightOfBTree(Node1 root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(HeightOfBTree(root.left), HeightOfBTree(root.right));
        }

        static void dMain()
        {
            Node1 root = null;
            root = new Node1(15);
            root.left = new Node1(10);
            root.right = new Node1(20);
            root.left.left = new Node1(8);
            root.left.right = new Node1(12);
            root.right.left = new Node1(16);
            root.right.right = new Node1(25);
        }

    }

    public class Node1
    {
        public int key;

        public Node1 left = null;
        public Node1 right = null;
        public Node1(int key) => this.key = key;
    }
}
