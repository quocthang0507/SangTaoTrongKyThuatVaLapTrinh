using System;

namespace Bai1._1_SoThanThien
{
	class Program
	{
		static int mn = 90;
		static int[] s = new int[mn];

		static void Main(string[] args)
		{
			Run();
			Console.ReadKey();
		}

		private static void Run()
		{
			int n = Find();
			for (int i = 0; i < n; i++)
			{
				Console.Write(s[i] + " ");
			}
			Console.WriteLine($"Tong cong: {n} so");
		}

		private static int Find()
		{
			int d = 0;
			for (int x = 10; x < 100; x++)
			{
				if (UCLN(x, SoDao(x)) == 1)
					s[d++] = x;
			}
			return d;
		}

		private static int SoDao(int x)
		{
			int y = 0;
			do
			{
				y = y * 10 + (x % 10);
				x /= 10;
			} while (x != 0);
			return y;
		}

		private static int UCLN(int a, int b)
		{
			int r;
			while (b != 0)
			{
				r = a % b;
				a = b;
				b = r;
			}
			return a;
		}
	}
}
