using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILEGIFS
{
	class Program
	{
		public static string get(string strSource, string strStart, string strEnd)
		{
			int Start, End;
			if (strSource.Contains(strStart) && strSource.Contains(strEnd))
			{
				Start = strSource.IndexOf(strStart, 0) + strStart.Length;
				End = strSource.IndexOf(strEnd, Start);
				return strSource.Substring(Start, End - Start);
			}
			else
			{
				return "";
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Filename..");
			string filename = Console.ReadLine();
			List<string> st = new List<string>();
			string[] readText = File.ReadAllLines(filename + ".txt");
			foreach (string s in readText)
			{
				if (s.Contains("gif") == true && s.Contains("200") == true && s.Contains("GET") == true)
				{
					// var te = s.Split(' ');
					string data = get(s, "images/", "HTTP");
					// st.Add(te[7].Substring(8).ToString());
					st.Add(data);
				}
			}
			List<string> slist = st.Distinct().ToList();
			foreach (string s in slist)
			{
				Console.WriteLine(s);
			}
			Console.ReadLine();
		}
	}
}