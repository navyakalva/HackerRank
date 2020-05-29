﻿using System;

namespace dynamicprogramming
{

    public class fibonacci
    {
        //public static int Fib(int n)//using recurssion
        //{
        //    if (n <= 1)
        //    {
        //        return n;
        //    }
        //    else
        //    {
        //        return Fib(n - 1) + Fib(n - 2);
        //    }
        //}

        //// driver code 
        //public static void Main(string[] args)
        //{
        //    int n = 9;
        //    Console.Write(Fib(n));
        //}

        static int fib(int n)//dynamic programming
        {

            // Declare an array to  
            // store Fibonacci numbers. 
            // 1 extra to handle  
            // case, n = 0 
            int[] f = new int[n + 2];
            int i;

            /* 0th and 1st number of the  
               series are 0 and 1 */
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers 
                   in the series and store it */
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        // Driver Code 
        public static void Main()
        {
            int n = 9;
            Console.WriteLine(fib(n));
        }
    }
}
