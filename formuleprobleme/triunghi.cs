using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class triunghi
    {
        public float x1;
        public float y1;
        public float x2;
        public float y2;
        public float x3;
        public float y3;
        public float aria;
        public float x;
        public float y;
        public float z;
        public float semiperimetrul;

        public triunghi(float px1, float py1, float px2, float py2, float px3, float py3)
        {
            x1 = px1;
            y1 = py1;
            x2 = px2;
            y2 = py2;
            x3 = px3;
            y3 = py3;
        }

        public triunghi(float px, float py, float pz)
        {
            x = px;
            y = py;
            z = pz;
        }

        public void calculeazaariaPuncte()
        {
            calculeazalungimileLaturilor();
            calculeazaariaLaturi();

        }

        public float distanta(float a1, float b1, float a2 , float b2)
        {
            return (float)Math.Sqrt(Math.Abs(a1 - a2) * Math.Abs(b1 - b2));
        }

        public void calculeazalungimileLaturilor()
        {
            x = distanta(x1, y1, x2, y2);
            y = distanta(x2, y2, x3, y3);
            z = distanta(x1, y1, x3, y3);

        }
        public void calculeazaariaLaturi()
        {
            
            if (x <= 0 || y <= 0 || z <= 0) { aria = 1; }
            if (z>=x+y || y >= x + x || z >= y + z) { aria = 2; }
            semiperimetrul = (x + y + z) / 2;
            aria = (float) Math.Sqrt(semiperimetrul * (semiperimetrul - x) * (semiperimetrul - y) * (semiperimetrul - z));

        }
 
    }
}
