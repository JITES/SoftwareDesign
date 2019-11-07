using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.DataStructure.LinkedList
{
    class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void AddNode(Node n)
        {
            if (head == null)
            {
                head = n;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = n;
            }
        }

        public void InsertInLinkedList(Node head,int data, int position)
        {
            Node newNode = new Node(data);

            if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node prev = null;
                Node current = head;
                int k = 1;
                while (current != null && k<position)
                {
                    prev = current;
                    current = current.next;
                    k++;
                }
                newNode.next = prev.next;
                prev.next = newNode;
            }

            
        }

        public void ReverseList(Node head)
        {
            Node prev = null, current = head, next = null;


            while (current!= null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
    }

    

}