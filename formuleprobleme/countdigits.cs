using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
   public class countdigits
    {

       public int nr = 0;
       public int nrdig = 0;

       public countdigits(int pnr)
       {
           nr = pnr;
       }

       public void calculeaza()
       {
           int n = nr;
           int nrtmp = 0;
           do
           {
               n /= 10;
               nrtmp++;
           } while (n > 0);
           nrdig = nrtmp;
       }

    }
}
