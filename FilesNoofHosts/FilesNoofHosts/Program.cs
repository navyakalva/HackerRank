﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilesNoofHosts
{

    class Hosts
    {

        public string name { get; set; }
        public int count { get; set; }
    }
    class Solution
    {
        static void Main(string[] args)
        {
            // read the string filename
            List<Hosts> hosts = new List<Hosts>();
            string filename = Console.ReadLine();
            string[] readText = File.ReadAllLines(filename + ".txt");
            foreach (string s in readText)
            {

                String host = String.Empty;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!s[i].Equals(' '))
                    {

                        host += s[i];
                    }
                    else
                    {
                        break;
                    }
                }

                int? count = (from h in hosts
                              where h.name == host
                              select h.count).FirstOrDefault();

                if (count == 0)
                {
                    hosts.Add(new Hosts { name = host, count = 1 });
                }
                else
                {
                    hosts.Where(w => w.name == host).ToList().ForEach(i => i.count = ((int)count + 1));
                }
            }
            var ordenada = hosts.OrderBy(m => m.name).ThenBy(m => m.name);
            foreach (Hosts h in ordenada)
            {
                Console.WriteLine(h.name + h.count);
            }
        }
    }

}
