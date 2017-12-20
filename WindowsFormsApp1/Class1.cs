using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Class1
    {
        public Class1(string S)
        {
            S = S.Trim();
            S = S.Replace(" ", "");
            S = S.Replace("-", "");
            string S2 = "";
            for (int i = 0; i < S.Length; i++)
            {
                string s1 = S.Substring(i);

                if ((i % 3 == 0) && (i > 0) && (S.Substring(i).Length > 1))
                {
                    S2 += "-";
                }
                else if ((i % 3 == 0) && (i > 0) && (S.Substring(i).Length == 1))
                {
                    S2 += "-";
                }
                S2 += S[i];
            }


            //int pos = S2.LastIndexOf("-");
            //string last = S2.Substring(pos+1);
            //if(last.Length == 1)
            //{
            //    string ss1 = S2.Substring(pos -1, 1 );
            //    string ss2 = S2.Substring(S2.LastIndexOf("-"), 1);
            //    S2 = S2.Replace(S2.Substring(S2.LastIndexOf("-"), 1), ss1);
            //}
        }
    }
}
