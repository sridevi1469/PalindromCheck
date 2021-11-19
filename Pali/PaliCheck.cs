using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pali
{
    public class PaliCheck
    {

        public string checkPalindrome(string str)
        {
            string result = String.Empty;

            if (str.Length >= 3)
            { 

            result = (IsPalindrome(str)) ? "true" : "false";

            if (result == "true")
                return "String is Palindrome   " + str;

            else
                return longestPali(str);
           }
            else
            {
                return "Enter min 3 characters";
            }
        }

        public string longestPali(string str)
        {

            if (str == null || str.Length < 1) return "";

            int start = 0; int end = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int len1 = expandFromMiddle(str, i, i);
                int len2 = expandFromMiddle(str, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - ((len - 1) / 2);
                    end = i + (len / 2);
                }
            }
            var returnstring = str.Substring(start, end - start + 1);

            if (returnstring.Length >= 3)
                return "String is palindrom and longest palindrome string is " + returnstring;
            else
                return "String is not palindrome";


        }

        public int expandFromMiddle(string s, int leftVal, int rightVal)
        {
            char[] charA = s.ToCharArray();
            if (s == null || leftVal > rightVal) return 0;

            while (leftVal >= 0 && rightVal < s.Length && charA[leftVal] == charA[rightVal])
            {
                leftVal--;
                rightVal++;
            }

            return rightVal - leftVal - 1;
        }


        protected bool IsPalindrome(string str)
        {
            bool isPalindrome = false;

           // String local = new string(' ', str.Length);
            string local = str;

            foreach (char c in str)
            {
                if (!Char.IsWhiteSpace(c))
                {
                    local += c;
                }
            }

            local = local.Trim();

            char[] charArray = local.ToCharArray();
            Array.Reverse(charArray);

            string backwards = new string(charArray);

            isPalindrome = String.Compare(local, backwards, StringComparison.Ordinal) == 0;

            return isPalindrome;
        }
    }
}

