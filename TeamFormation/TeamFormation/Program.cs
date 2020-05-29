using System;

namespace TeamFormation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter team size value:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array size n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(a);
            for (int i = n - 1; i >= 0; i--)
            {
                if (k > 0)
                {
                    sum = sum + a[i];
                    k = k - 1;
                }
            }
            Console.WriteLine("Sum of the selected employees :" + sum);
        }
    }
    //class Program
    //{
    //    public static void Main()
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int[] a = new int[n];
    //        List<int> li = new List<int>();
    //        for (int i = 0; i < n; i++)
    //        {
    //            a[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //        int team = Convert.ToInt32(Console.ReadLine());
    //        int k = Convert.ToInt32(Console.ReadLine());
    //        int sum = 0;
    //        for (int j = 0; j < team; j++)
    //        {
    //            li.Clear();
    //            for (int i = 0; i < n; i++)
    //            {
    //                if (i < k)
    //                {
    //                    li.Add(a[i]);
    //                    li.Add(a[n - i - 1]);
    //                }
    //            }
    //            for (int i = 0; i < n; i++)
    //            {
    //                if (li.Max() == a[i])
    //                    a[i] = 0;
    //            }

    //            sum += li.Max();
    //        }
    //        Console.WriteLine(sum);
    //    }
 }
