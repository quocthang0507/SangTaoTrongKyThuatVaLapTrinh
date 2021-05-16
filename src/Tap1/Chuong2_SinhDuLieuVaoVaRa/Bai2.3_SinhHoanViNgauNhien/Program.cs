using System;
using System.Text;

namespace Bai2._3_SinhHoanViNgauNhien
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			while (true)
			{
				Console.WriteLine("Mảng hoán vị ngẫu nhiên 20 phần tử: ");
				Print(Gen(20));
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
			for (int i = 0; i < n; i++)
			{
				a[i] = i + 1;
			}
			for (int i = 0; i < n; i++)
			{
				int j = random.Next(n);
				int t = a[0];
				a[0] = a[j];
				a[j] = t;
			}
			return a;
		}
	}
}
