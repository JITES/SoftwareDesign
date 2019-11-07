using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.program
{
    class isUniqueString
    {
        static void DMain() => _  = IsUniqueString("TesT");
        public static bool IsUniqueString(string input)
        {
            char[] strChar = input.ToCharArray();
            bool[] chars = new bool[128];

            for (int i = 0; i < input.Length; i++)
            {
                int val = strChar[i];
                if (chars[val])
                {
                    return false;
                }
                chars[val] = true;
            }

            return true;
        }
    }
}
