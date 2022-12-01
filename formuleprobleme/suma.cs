using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class suma
    {
        public int n;
        public int s;

        public suma(int pn)
        {
            n = pn;
        }

        public void calculeaza()
        {
            int tmps = 0;
            for (int i = 0; i < n; i++)
            {
                tmps += i;
            }
            s = tmps;
        }
    }
}
