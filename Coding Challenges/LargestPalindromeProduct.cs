using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class LargestPalindromeProduct
    {
        public static bool LargestProduct(int x)
        {
            var n = 0;
            var m = x;

            while (x > 0)
            {
                n = n * 10 + x % 10;
                x = x / 10 | 0;
            }
            return n == m;
        }
    }
}
