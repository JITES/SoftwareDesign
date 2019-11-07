using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.DataStructure.Stack
{
    class BalancingParanthesis
    {
        public bool IsParanthesisBalanced(char[] expression)
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                // Handles opening expressions
                if (expression[i] == '{' || expression[i] == '(' || expression[i] == '[')
                    st.Push(expression[i]);

                // Handles closing expressions
                if (expression[i] == '}' || expression[i] == ')' || expression[i] == ']')
                {
                    // If exp - x is the only closing expression then it is not balanaced hence we return false
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    /* Here we pop top element from stack and match it with it correct pair
                     */
                    else if (!IsMatchinPair(st.Pop(), expression[i]))
                    {
                        return false;
                    }
                }
            }

            return st.Count == 0 ? true : false;
        }

        private bool IsMatchinPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }
    }
}
