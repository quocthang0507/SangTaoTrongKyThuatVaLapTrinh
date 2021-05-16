using System;
using System.Text;

namespace Bai2._1_SinhNgauNhienTheoKhoang
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			while (true)
			{
				Console.WriteLine("Số nguyên ngẫu nhiên trong nửa đoạn -8..8: ");
				Print(Gen(20, -8, 8));
				ConsoleKey input = Console.ReadKey().Key;
				if (input != ConsoleKey.Enter)
					break;
			}
		}

		private static void Print(int[] a)
		{
			foreach (var x in a)
			{
				Console.Write(x + " ");
			}
			Console.WriteLine();
		}

		private static int[] Gen(int n, int d, int c)
		{
			Random random = new Random();
			int len = c - d + 1;
			int[] a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = d + random.Next(len);
			}
			return a;
		}
	}
}
