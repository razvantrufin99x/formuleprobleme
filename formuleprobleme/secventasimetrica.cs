using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class secventasimetrica
    {
        public int n;
        string sc;

        public secventasimetrica(int pn)
        {
            n = pn;
        }

        public void generate()
        {
            for (int i = 1; i <= n / 2; i++)
            {
                sc += i.ToString();
            }
            for (int i = (n+n%2)/2; i>=0; i --)
            {
                sc += i.ToString();
            }
        }
    }
}
