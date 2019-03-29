using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera
{
    class Vector
    {
        private int [] vec;
        public Vector()
        {
            vec = new int[1000];
        }
        public void Llenar()
        {
            for(int i = 1; i <= 999; i++)
            {
                vec[i] = 1;
            }
        }
        public void Colar()
        {
            for(int i = 2; i < 1000; i++)
            {
                if (vec[i] == 1)
                {
                    int j = i + 1;
                    for(;j<1000;j++)
                    {
                        if (j % i == 0)
                        {
                            vec[i] = 0;
                        }
                    }
                }
            }
        }
    }
}
