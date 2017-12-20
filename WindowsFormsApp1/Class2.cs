using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Class2
    {
        public Class2( int[] A)
        {
            // 3, 5, 6, 3, 3, 5 

            int num = 0;
            HashSet<Int32> hset = new HashSet<Int32>();

            for (int i = 0; i < A.Length; i++)
            {
                hset.Add(A[i]);                

                if (hset.Contains(A[i+1]))
                {
                    num++;
                }
            }

            //return num;
        }
    }
}
