using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaliAPI.Model
{
    public class PaliCheck
    {
       
      
         
        public  string longestPali(string str)
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
            return str.Substring(start, end - start + 1);


        }

        public  int expandFromMiddle(string s, int leftVal, int rightVal)
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


    }
}

