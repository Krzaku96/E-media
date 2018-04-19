using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMedia
{
     
    public class EncryptionDecryption
    {
        public string encrypt(string image)
        {
            string tmp = image;
            char[] a = tmp.ToCharArray();
            string b = "";

            for (int i = 0; i < a.Length; i++)
            {
                int RSA_E = 0;
                int n = 0;
                if (b == "")
                    b = b + RSA.Mod(a[i], RSA_E, n); 

            }
        }
    }
}
