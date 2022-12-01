using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class factorial
    {
        public int n = 0;
        public int r = 0;

        public factorial(int pn)
        {
            n = pn;
        }

        public void calculeaza()
        {
            int x = 0;
            for (int i = 1; i < n; i++)
            {
                x *= i;
            }
            r = x;
        }

    }
}
