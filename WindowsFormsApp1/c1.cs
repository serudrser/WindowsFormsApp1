using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class c1
    {
        public c1()
        {
            int[] A1 = { 1, 3, 6, 4, 1, 2, 9 };
            //int[] A1 = { 1, 2, 3 };
            //int[] A1 = { -1, -3 };

            //Array.Sort(A1);

            solution2(A1);
        }


        public int solution2(int[] A)
        {
            int num = 1;
            int num2 = 1;

            HashSet<Int32> hset = new HashSet<Int32>();
            SortedSet<Int32> sSet = new SortedSet<Int32>();

            for (int i = 0; i < A.Length; i++)
            {
                hset.Add(A[i]);
                sSet.Add(A[i]);

                while (hset.Contains(num))
                {
                    num++;
                }
                while (sSet.Contains(num2))
                {
                    num2++;
                }
            }

            //int num2 = 1;
            //int pos = 1;
            //foreach(int i in sSet)
            //{
            //    if((i+1) == sSet.ElementAt(pos))
            //    {
            //        num2 = i + 2;
            //        pos++;
            //        //break;
            //    }
            //}

            return num;
        }


        public int solution(int[] A)
        {
            Array.Sort(A);
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int x = 1;
            int mic = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {

                if ((x == A[i]) & ((x + 1) < A[i + 1]))
                {

                    mic = x + 1;
                    Console.WriteLine("cel mai mic   " + mic);
                    return mic;
                }
                else { x++; }

            }
            if ((mic == 0) & (A[A.Length - 1] > 0))
            {
                mic = A[A.Length - 1] + 1;
            }
            else
            {
                mic = 1;
            }
            return mic;
        }
    }
}

