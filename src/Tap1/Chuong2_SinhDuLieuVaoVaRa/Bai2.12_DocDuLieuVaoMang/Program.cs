using System;
using System.IO;

namespace Bai2._12_DocDuLieuVaoMang
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "Input.txt";
			int n = 0, m = 0;
			int[,] a = Read(filename, ref n, ref m);
			Print(a, n, m);
			Console.ReadKey();
		}

		static int[,] Read(string filename, ref int n, ref int m)
		{
			if (!File.Exists(filename))
				return null;
			char[] cc = new char[] { ' ', '\n', '\t', '\r' };
			string[] ss = File.ReadAllText(filename).Split(cc, StringSplitOptions.RemoveEmptyEntries);
			int[] c = Array.ConvertAll(ss, new Converter<string, int>(int.Parse));
			n = c[0];
			m = c[1];
			int[,] a = new int[n, m];
			int k = 2;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					a[i, j] = c[k++];
				}
			}
			return a;
		}

		static void Print(int[,] a, int n, int m)
		{
			Console.WriteLine($"Mang a chieu cao n = {n}, chieu rong m = {m}:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write($"{a[i, j]}\t");
				}
				Console.WriteLine();
			}
		}
	}
}
