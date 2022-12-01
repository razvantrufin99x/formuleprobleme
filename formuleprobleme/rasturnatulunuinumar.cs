using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class rasturnatulunuinumar
    {
        public int n=0;
        public int rn = 0;
        public rasturnatulunuinumar(int pn)
        {
            n = pn;
        }

        public void calculeaza()
        {
            int r = 0;
            int tmpn = n;
            while (tmpn>0)
            {
                r = r * 10 + n % 10;
                n /= 10;
            }
            rn = r;
        }

    }
}
