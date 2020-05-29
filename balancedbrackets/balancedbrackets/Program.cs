using System;
using System.Collections;

namespace Balancedbrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter no of exp");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter exp");
                string exp = Console.ReadLine();
                bool res = BalancedorNot(exp);
                if (res)
                {
                    Console.WriteLine("Balanced");
                    Console.WriteLine("sum is" + sum);
                }
                else
                    Console.WriteLine("Not Balanced");
            }
            Console.ReadLine();
        }

        public static bool BalancedorNot(string exp)
        {
            char[] a = exp.ToCharArray();//convert string to character array
            bool result = true;
            int sum = 0;
            Stack s = new Stack();
            foreach (var b in a)
            {
                string str = b.ToString();
                if (str == "[" || str == "{" || str == "(")
                {
                    s.Push(str);
                }
                else if (s.Count > 0)
                {
                    if (str == "]")
                    {
                        if (s.Peek().ToString() == "[")
                        {
                            s.Pop();
                            sum++;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    if (str == "}")
                    {
                        if (s.Peek().ToString() == "{")
                        {
                            s.Pop();
                            sum++;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    if (str == ")")
                    {
                        if (s.Peek().ToString() == "(")
                        {
                            s.Pop();
                            sum++;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
