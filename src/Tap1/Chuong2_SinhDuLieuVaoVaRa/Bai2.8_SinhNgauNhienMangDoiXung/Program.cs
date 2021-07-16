using System;

namespace Bai2._8_SinhNgauNhienMangDoiXung
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 10;
			int[,] a = Gen(n);
			Print(a, n);
			Console.ReadKey();
		}

		static void Print(int[,] a, int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(a[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		static int[,] Gen(int n)
		{
			int[,] a = new int[n, n];
			Random random = new Random();
			for (int i = 0; i < n; i++)
			{
				// Duong cheo chinh
				a[i, i] = random.Next(100);
				// Cac phan tu nam tren duong cheo chinh
				for (int j = i + 1; j < n; j++)
				{
					a[i, j] = random.Next(100);
					a[j, i] = a[i, j];
				}
			}
			return a;
		}
	}
}
