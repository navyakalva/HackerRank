using System;
using System.Collections.Generic;
using System.Text;

namespace dynamicprogramming
{
    class SubsequenceRemoval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> li = new List<int>();
            List<int> li1 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (!li.Contains(a[i]))
                    li.Add(a[i]);
                else
                    li1.Add(a[i]);
            }
            li1.Sort();
            Console.WriteLine("Output is");
            for (int i = 0; i < li1.Count; i++)
            {
                Console.WriteLine(li1[i]);
            }
        }
    }
}
