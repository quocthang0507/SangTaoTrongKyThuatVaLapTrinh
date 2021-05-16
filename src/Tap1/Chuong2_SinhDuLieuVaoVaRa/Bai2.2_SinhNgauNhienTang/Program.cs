using System;
using System.Text;

namespace Bai2._2_SinhNgauNhienTang
{
	class Program
	{
		const int n = 20;
		const int d = 10;

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			while (true)
			{
				Console.WriteLine($"{n} số nguyên ngẫu nhiên tăng: ");
				Print(Gen(n));
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

		private static int[] Gen(int n)
		{
			Random random = new Random();
			int[] a = new int[n];
			a[0] = random.Next(5);
			for (int i = 1; i < n; i++)
			{
				a[i] += a[i - 1] + random.Next(d);
			}
			return a;
		}
	}
}
