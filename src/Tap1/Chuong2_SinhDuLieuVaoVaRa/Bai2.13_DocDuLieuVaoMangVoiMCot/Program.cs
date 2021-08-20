using System;
using System.IO;

namespace Bai2._13_DocDuLieuVaoMangVoiMCot
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
			int[] c = Array.ConvertAll(File.ReadAllText(filename).Split(cc, StringSplitOptions.RemoveEmptyEntries), new Converter<string, int>(int.Parse));
			int k = 0;
			m = c[k++];
			n = (c.Length - 1) / m;
			int[,] a = new int[n, m];
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
