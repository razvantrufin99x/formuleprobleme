using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formuleprobleme
{
    public class triunghidenumere
    {
        public int x;
        public int x0;
        public int x1;
        public int x2;
        public int x3;

        public triunghidenumere(int px)
        {
            x = px;
        }

        public void splitnumber2digit()
        {
            int tmpx = x;
            x0 = tmpx % 10;
            tmpx = x / 10;
            x1 = tmpx % 10;
            tmpx = x / 10;
            x2 = tmpx % 10;
            tmpx = x / 10;
            x3 = tmpx % 10;
            tmpx = x / 10;


        }

        public void printdigits(ref TextBox t)
        {
            t.Text += "\r\n" + x2.ToString();
            t.Text += "\r\n" + x3.ToString() + x2.ToString() + x1.ToString();
            t.Text += "\r\n" + x.ToString() + x3.ToString() + x2.ToString() + x1.ToString() + x0.ToString(); 

        }
       

    }
}
