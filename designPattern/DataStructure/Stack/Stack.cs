using designPattern.DataStructure.Stack;
using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.DataStructure
{
    public class StackC
    {
        int top = -1;
        int MX_SZ = 100;
        int[] A;
        public void Push(int[] stack,int x)
        {
            A = stack;
            if (top == MX_SZ - 1)
            {
                Console.WriteLine("StackOverflow");
                return;
            }
            top++;
            A[top] = x;
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Empty Stack");
            }
            top--;
        }

        public int Top()
        {
            return A[top];
        }

        public bool IsEmpty()
        {
            if (top == -1)
            {
                return false;
            }
            return true;
        }
    }

    class StackImplementation
    {
        public static void DMain()
        {
            StackImplementation s = new StackImplementation();
            Console.WriteLine(s.ReverseString());

            BalancingParanthesis bp = new BalancingParanthesis();
            char[] expresssion = { '{', '(', ')', '}', '[', ']' };
            bool IsBalanced = bp.IsParanthesisBalanced(expresssion);
            Console.WriteLine(IsBalanced.ToString());
            Console.ReadKey();
        }

        public string ReverseString()
        {
            string name = "Jitesh";
            char[] nameInChar = name.ToCharArray();
            Stack<char> vs = new Stack<char>();

            foreach (var item in nameInChar)
            {
                vs.Push(item);
            }

            int k = 0;
            while (vs.Count != 0)
            {
                nameInChar[k++] = vs.Pop();
            }

            return new string(nameInChar);
        }
    }
}
