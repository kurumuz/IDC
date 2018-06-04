using System.Linq;
using System.Collections.Generic;
using System;

namespace IDC
{
    class function
    {
        public static int FarkHesapla(string giri1, string giri2)
        {
            var giri1trimmed = string.Concat(giri1.Where(c => !char.IsWhiteSpace(c))).ToLower();
            var giri2trimmed = string.Concat(giri2.Where(c => !char.IsWhiteSpace(c))).ToLower();
            int farktoplam = 0;
            int returnvalue = 1;
            Dictionary<string, int> h1 = new Dictionary<string, int>();
			Dictionary<string, int> h2 = new Dictionary<string, int>();
			Dictionary<string, int> h3 = new Dictionary<string, int>();
            const string lol = "abcçdefgğhıijklmnoöprsştuüyzx0123456789.()/?-=+,";

            foreach (char c in lol)
            {

                h1.Add(c.ToString(), giri1trimmed.Split(c).Length - 1);    
                h2.Add(c.ToString(), giri2trimmed.Split(c).Length - 1);
				h3.Add(c.ToString(), Math.Abs(h1[c.ToString()] - h2[c.ToString()]));				
				farktoplam = farktoplam + h3[c.ToString()];
            }
            
			float s1l = giri1trimmed.Length;
            float x = s1l / 27;
            Console.WriteLine(giri1trimmed.Length);
            Console.WriteLine("x * 2.7 =" + x * 2.7 + " xraw = " + x );
		    Console.WriteLine("fark = " + farktoplam);
            foreach (char c in lol)
            {
                if (h3[c.ToString()] < x & farktoplam < x * 2.7)
                {
                    returnvalue = 1;
                }
                else 
                {
                    returnvalue = 0;
                    break;
                }
            }
            
            return returnvalue;
        }
    }
}