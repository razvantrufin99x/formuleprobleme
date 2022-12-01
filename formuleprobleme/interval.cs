using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class interval
    {
        public float min;
        public float max;

        public interval(float a, float b)
        {
            min = a;
            max = b;
        }

        public bool eininterval(float x)
        {
            if (x >= min && x <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
