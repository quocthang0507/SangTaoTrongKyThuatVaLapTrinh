using System;
using System.IO;

namespace Bai2._11_DocDuLieuVaoMangDoiXung
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "Input.txt";
			int n = 0;
			int[,] a = Read(filename, ref n);
			Print(a, n);
			Console.ReadKey();
		}

		static int[,] Read(string filename, ref int n)
		{
			if (!File.Exists(filename))
				return null;
			char[] cc = new char[] { ' ', '\n', '\t', '\r' };
			int[] c = Array.ConvertAll(File.ReadAllText(filename).Split(cc, StringSplitOptions.RemoveEmptyEntries), new Converter<string, int>(int.Parse));
			int k = 0;
			n = c[k++];
			int[,] a = new int[n, n];
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
				{
					a[i, j] = a[j, i] = c[k++];
				}
			}
			return a;
		}


		static void Print(int[,] a, int n)
		{
			Console.WriteLine($"Mang a n x n voi n = {n}");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write($"{a[i, j]}\t");
				}
				Console.WriteLine();
			}
		}
	}
}
