using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EMedia
{
    class RSA
    {
        public static long square(long s)
        {
            return (s * s);
        }

        public static long Mod(int e, int p, int q)
        {
            if(p==0)
            {
                return 1;
            }
            else if(p%2==0)
            {
                return square(Mod(e, p / 2, q)) % q;
            }
            else
                return ((e%q) * Mod(e, p-1,q)) % q;
        }
    }
}
