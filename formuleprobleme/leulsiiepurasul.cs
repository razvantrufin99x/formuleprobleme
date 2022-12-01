using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class leulsiiepurasul
    {
        public float v1; //viteza iepure
        public float v2; //viteza leu
        public float t0; // timpul dupa care apare leul

        public leulsiiepurasul(float pv1, float pv2, float pt0)
        {
            v1 = pv1;
            v2 = pv2;
            t0 = pt0;
        }
        public float calculeaza()
        {
            return (v2 > v1 ? v1 * t0 / (v2 - v1) : -1);
        }
    }
}
