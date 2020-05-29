using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Files
{
    class LINQeg
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 5, 6, 7, 3, 2, 8, 9, 1, 10 };
            Console.WriteLine("Original Array");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //LINQ - Language Integrated Query 
            //Query Syntax
            var res = (from i in numbers
                       where i % 2 == 0
                       select i).ToList();
            //Method Syntax
            var res1 = numbers.Where(x => x % 2 == 0).Select(x => x);
            Console.WriteLine("The even numbers from the collection:");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
