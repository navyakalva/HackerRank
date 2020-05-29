using System;
using System.Collections.Generic;
using System.Text;

namespace dynamicprogramming
{
    class TeamFormation
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter k value:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array size n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(a);
            for(int i=n;i>=0;i--)
            {    if (k > 0)
                {
                    sum = sum + a[i];
                    k = k - 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

