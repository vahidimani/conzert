using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Numbers with space. Example :1 2 5 8 7 9 6 3 2");

            string v = Console.ReadLine();

            string[] v1 = v.Split(' ');
            int l = v1.Length;
            int[] v2 = new int[l];
            for (int i = 0; i < v1.Length; i++)
            {
                v2[i] = Convert.ToInt32(v1[i]);
            }
            Array.Sort(v2);
            int min = v2[0];
            int max = v2[l-1];
            double Q1=0,Q2,Q3=0;
            if (l%2==0)
            {
                Q2 = (v2[l / 2] + v2[(l / 2)-1]) / 2.0;
                int m = l / 2;
                if (m%2==0)
                {
                    Q1 = (v2[m / 2] + v2[(m / 2) - 1]) / 2.0;
                    Q3 = (v2[(m / 2) * 3] + v2[(m / 2) * 3 - 1]) / 2.0;
                }
                else
                {
                    Q1 = v2[(m / 2)];
                    int n = (l - (l / 2));
                    int c = (l - n) / 2;
                    int d = c + n;
                    Q3 = v2[d];
                }
                
            }
            else
            {
                Q2 = v2[(l/2)];
                int m = l / 2;
                Q1 = (v2[m / 2] + v2[(m / 2) - 1]) / 2.0;
                int n = (l - (l / 2));
                int c = (l - n) / 2;
                int d = c + n;
                Q3 = (v2[d] + v2[d - 1]) / 2.0;
                
            }

            
            double IQR=Q3-Q1;
            
            Console.WriteLine("Min: " + min +"          Max: " + max);
            Console.WriteLine("Q1: " + Q1 + "          Q2: " + Q2 + "          Q3: " + Q3);
            int r = 0;
            for (int i = 0; i < l; i++)
            {
                if (v2[i] > Q3 + IQR || v2[i] < Q1 - IQR)
                {
                    Console.WriteLine("outlier = " + v2[i] + "  ");
                    r++;
                }
            }
            if (r==0)
            {
                Console.WriteLine("There is No Outlier.");
            }
            Console.Read();
            // 1 2 3 4 5 6 7 8 9 10 11 12
            //25 29 3 32 85 33 27 28
        }
    }
}