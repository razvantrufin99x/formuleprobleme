using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formuleprobleme
{
    public class compuschimic
    {
        public float masamolecularacompuschimic;

        public List<formuleprobleme.atom> compusmolecular = new List<formuleprobleme.atom>();
        public List<float> numardeatomi = new List<float>();

        public compuschimic()
        { 
            
        }

        public void fmasamolecularacompuschimic()
        {
            float t=0.0f;
            for (int i = 0; i < compusmolecular.Count; i++)
            {
                t += compusmolecular[i].masaatomica * numardeatomi[i];
            }
            masamolecularacompuschimic = t;
        }

    }
}
