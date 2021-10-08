using System;
using System.IO;

namespace Bai4._4_SapMang
{
	class Program
	{
		const int mn = 50000;
		const string filename = "SapTang.dat";
		static int[] a = new int[mn];
		static int n = 0;

		static void Main(string[] args)
		{
			Run(150);
			Console.ReadLine();
		}

		public static void Run(int nn)
		{
			n = nn;
			Console.WriteLine("\nSinh ngau nhien " + n + " phan tu cho mang a[0.." + (n - 1) + "]");
			Gen();
			Console.WriteLine("\nQuick sort...");
			QSort(0, n - 1);
			Console.WriteLine("\nGhi file " + filename + "...");
			Ghi();
			Console.WriteLine("\nKiem tra lai file " + filename + "\n\n");
			ShowFile();
		}

		private static void ShowFile()
		{
			Console.WriteLine(File.ReadAllText(filename));
		}

		private static void Ghi()
		{
			StreamWriter writer = File.CreateText(filename);
			writer.WriteLine(n);
			for (int i = 0; i < n; ++i)
				writer.Write(a[i] + ((i % 10 == 9) ? "\n" : " "));
			writer.Close();
		}

		private static void QSort(int d, int c)
		{
			int i = d;
			int j = c;
			int m = a[(i + j) / 2];
			int t;
			while (i <= j)
			{
				while (a[i] < m)
				{
					++i;
				}
				while (m < a[j])
				{
					--j;
				}
				if (i <= j)
				{
					t = a[i];
					a[i] = a[j];
					a[j] = t;
					++i;
					--j;
				}
			}
			if (d < j) QSort(d, j);
			if (i < c) QSort(i, c);
		}

		static void MinSort()
		{
			int i;
			int j;
			for (i = 0; i < n; ++i)
				for (j = i + 1; j < n; ++j)
					if (a[j] < a[i])
					{
						int t = a[i];
						a[i] = a[j]; a[j] = t;
					}
		}

		private static void Gen()
		{
			Random r = new Random();
			for (int i = 0; i < n; i++)
			{
				a[i] = r.Next(100);
			}
		}
	}
}
