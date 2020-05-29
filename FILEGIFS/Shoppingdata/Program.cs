using System;
using System.Collections.Generic;
using System.IO;

namespace Shoppingdata
{
    class Program
    {
        static void Main(string[] args)
        {
            
            File.ReadAllLines("Products.txt");
            string[] word;
            List<string> validLines = new List<string>();
            foreach (string line in lines)
            {
                //   Console.WriteLine(line);
                word = line.Split(',');
                List<prd> objs = new List<prd>();
                prd p1 = new prd();
                p1.prdname = word[2];
                p1.qty = Convert.ToInt32(word[3]);
                objs.Add(p1);
                foreach (var item in objs)
                {
                    // Console.WriteLine(item.prdname+ "   "+item.qty);
                    var uniqueprdnames = (from i in objs
                                          select i.prdname).Distinct();
                    var qtycount = from i in objs
                                   group i by i.prdname into f



                }
            }
            Console.ReadLine();

        }
    }
}
prods.Add(p1);
            }
                    var res =
                                  from i in prods
                                  group i by i.prdname into f
                                  select new
                                  {
                                      pname = f.Key,
                                      AverageNumbers = f.Average(x => x.qty),
                                  };
FileStream fs = new FileStream("outputfile.txt", FileMode.Append, FileAccess.Write);
StreamWriter sw = new StreamWriter(fs);
            foreach (var r in res)
                {
                    Console.WriteLine(r.pname + "," + r.AverageNumbers);
                sw.WriteLine(r.pname + "," + r.AverageNumbers);
            }
                
            
            
            sw.Flush();
            fs.Close();
            Console.WriteLine("Content written to the File");
            Console.ReadLine();
        }
