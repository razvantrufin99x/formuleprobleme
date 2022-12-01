using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class NumereNaturale
    {

        public int max(int a, int b)
        { 
            return a > b ? a : b;
        }
        public int min(int a, int b)
        {
            return a < b ? a : b;
        }
        public bool egal(int a, int b)
        {
            return a == b ? true : false;
        }
        public bool diferit(int a, int b)
        {
            return a != b ? true : false;
        }
        public float media(int a, int b)
        {
            return (a + b) / 2;
        }
        public float media(ref int [] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s / a.Length;
        }
        public int sumacifrenumar(int pn)
        {
            int vn = pn;
            int s = 0;
            while (vn > 0)
            {
                s += vn % 10;
                vn /= 10;
            }
            return s;
        }
        public string perechi(int pn)
        {
            int  a, m;
            string s="";
            for(a = 1; a < pn ; a++)
                for( m = 1; a * m < pn ; m++)
                    s += " = " + a.ToString() + " : " + (a*m).ToString();
            return s;
        }
        public int divizor(int pn)
        {
            int x,rad;
            rad = (int)Math.Sqrt(pn);
            for (x = 2; x <= rad; x++)
            {
                if (pn % x == 0)
                {
                    return x;
                    //return pn/x;
                    //return pn;
                }
            }
            return 0;

        }

        public bool prim(int pn)
        {
            int d, prm = 1, rad;
            if (pn > 2)
                if (pn % 2 == 0) prm = 0;
                else
                    for (d = 3, rad = (int)Math.Sqrt(pn); d <= rad && prm > 0; d += 2)
                        if (pn % d == 0) prm = 0;
            if (prm == 1) return true;
            else return false;
        }

        public string descompunereinfactoriprimi(int pn)
        {
            int d, m;
            string s = "";
            for (d = 2; pn > 1; d++)
                for (m = 0; pn % d == 0; m++, pn /= d)
                    if (m > 0)
                        s += d.ToString() + "," + m.ToString() + " , ";
            return s;

        }

        public int cmmdc(int pn, int pm)
        {
            int rest;
            int n = pn;
            int m = pm;
            while (m > 0)
            {
                rest = n % m;
                n = m;
                m = rest;
            }
            return n;
        }

        public string multiplicitateafactoruluiprimpinn(int pn ,int pp )
        {
            int k = 0;
            int n = pn;
            int p = pp;
            string s = "";
            for (k = 0; n % p == 0; k++, n /= p) ;
            s += k.ToString() + ",";

            return s;
        }

        public string termenFibonacci(int pn)
        {
            int n = pn;
            int i;
            int f0 = 1;
            int f1 = 1;
            int f2 = 1;
            string s = "";
            for (i = 2; i <= n; i++)
            {
                f1 = f1 + f0;
                f0 = f1;
                f1 = f2;
            }
            s += n.ToString() + " , " + f2.ToString() + " , ";
            return s;
        }

        public int existamultiplualuiN(ref int[] pa, int pp)
        {
            int exista = 0;
            int i;
            int p = pp;
            for (i = 1; i <= pa.Length; i++)
                if (pa[i] % p == 0) exista = 1;
            if (exista == 1) return p;
            else return 0;
        }

        public bool numardedivizoriprimi(int pn, ref int [ ]x)
        {
            int n,  d, nr, i, oricare = 1;
            n = pn;
            for (i = 1; i < n; i++)
            {
                nr = 0;
                d = 2;
                while (x[i] > 1)
                {
                    if (x[i] % d == 0)
                    {
                        nr++;
                        while (x[i] % d == 0) x[i] /= d;
                        d++;
                    }
                    if (nr % 2 == 0) 
                        oricare = 0;
                }
                if (oricare == 1) return true;
                
            }
            return false;
        }


        public float factorialsecventa( int n , float x)
        {
            float i, f;
            float s, p=0.0f;
            for (f = s = i = 1; i <= n; i++)
            {
                f *= i;
                p *= x;
                s += p/f;
            }

            return s;
        }

        public double radical(double x)
        {
            //radical de ordinul 3 din x
            //3SQRT(x)

            float EPS = 0.0001f;
            double  r1, r2 = 1;
            do
            {
                r1 = r2;
                r2 = (2 * r1 + x/(r1*r1))/3;
            }
            while(Math.Abs(r2-r1)>=EPS);
            return r2;
        }
        //m * m *( n +1 )= x

        public int relatie(int x)
        { int i;
        for (i = 1; i * i <= x; i++)
            if (x % (i * i) == 0)
                return i;

        return 0;
        }

        public int sumade2nrprime(int vmax)
        {
            int n, a=0, rad, d, prim, exista=0, oricare = 1;
            for (n = 4; n <= vmax && oricare == 1; n++)
            {
                prim = 1;
                if (a > 2 && a % 2 == 0) prim = 0;
                else
                    for (rad = (int)Math.Sqrt(a), d = 3; prim == 1 && d <= rad; d += 2)
                        if (a % d == 0) prim = 0;
                if (prim == 1)
                {
                    prim = 1;
                    if (n - a > 2 && (n - a) % 2 == 0) prim = 0;
                    else
                        for (rad = (int)Math.Sqrt(n - a), d = 3; prim == 1 && d <= rad; d += 2)
                            if ((n - a) % d == 0) prim = 0;
                    if (prim == 1) exista = 1;
                }
                
                 if(exista == 0) oricare = 0;
            }
                
                if(oricare == 1) {
                    //da
                return 1;
                }
            else
                {       
             //nu
                 return 0;
                }
          
        }

        //pagina 57
    }
}
