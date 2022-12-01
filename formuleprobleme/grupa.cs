using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class grupa
    {
        public string grupul;
        public string operatorul;
        public string asociativitate;
        public grupa(string gru, string ope, string aso)
        {
            grupul = gru;
            operatorul = ope;
            asociativitate = aso;
        }
    }
}
