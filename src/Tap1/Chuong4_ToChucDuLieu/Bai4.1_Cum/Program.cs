using System;
using System.IO;

namespace Bai4._1_Cum
{
	class Program
	{
		private static string filename = "data.inp";
		private static string output = "data.out";

		static void Main(string[] args)
		{
			if (XuLy())
				KiemTra();
			Console.ReadLine();
		}

		public static bool XuLy()
		{
			string s = (File.ReadAllText(filename)).Trim();
			int[] st = new int[s.Length]; //stack
			int p = 0; //con tro stack
			int sc = 0; // dem so cum
			string ss = "";
			for (int i = 0; i < s.Length; i++)
			{
				switch (s[i])
				{
					case '(':
						st[++p] = i;
						break;
					case ')':
						if (p == 0)
						{
							Console.WriteLine("\nLoi: Thieu (");
							return false;
						}
						++sc;
						for (int j = st[p]; j <= i; j++)
						{
							ss += s[j];
						}
						ss += '\n';
						--p;
						break;
				}
			}
			if (p > 0)
			{
				Console.WriteLine("\nLoi: Du (");
				return false;
			}
			File.WriteAllText(output, (sc.ToString() + "\n" + ss));
			return true;
		}

		public static void KiemTra()
		{
			Console.WriteLine("\nInput file: " + filename);
			Console.WriteLine(File.ReadAllText(filename));
			Console.WriteLine("\nOutput file: " + output);
			Console.WriteLine(File.ReadAllText(output));
		}
	}
}
