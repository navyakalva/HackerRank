using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("abc.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            sw.WriteLine(name + " " + "Logged in" + " " + DateTime.Now);
            Console.WriteLine("Data written to the file");
            sw.Flush();
            fs.Close();
            Console.ReadLine();
        }
    }
}
