using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class cerc
    {
        public float x;
        public float y;
        public float centru;
        public float raza;
        public float aria;
        public float perimeter;
        public float diametrul;
        public float lungime;

        public void faria()
        {
            aria = (float)Math.PI * raza * raza;
        }

        public void fperimeter()
        {
            perimeter = 2 * (float)Math.PI * raza;
        }

    }
}
