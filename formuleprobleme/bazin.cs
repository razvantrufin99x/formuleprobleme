using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
   public class bazin
    {
       public int x;
       public int y;
       public int h1;
       public int h2;
       public int b;
       public int a;

       public bazin(int px, int py, int ph1, int ph2, int pb)
       {
           x = px;
           y = py;
           h1 = ph1;
           h2 = ph2;
           b = pb;
       }

       public void calculeaza()
       {
          
           b = (x-h1*(y-x))/(h2+h1);
           a = (y-x)+b;

       }

    }
}
