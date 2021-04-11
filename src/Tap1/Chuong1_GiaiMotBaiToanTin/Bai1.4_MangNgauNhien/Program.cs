using System;
using System.Collections;

namespace Bai1._4_MangNgauNhien
{
	class Program
	{
		static void Main(string[] args)
		{
			// Show(Gen(200));
			ShowStat(Stat(Gen(30)));
			Console.WriteLine("\nFinish");
			Console.ReadKey();
		}

		private static int[] Gen(int n)
		{
			int[] a = new int[n];
			Random r = new Random();
			for (int i = 0; i < n; i++)
			{
				a[i] = r.Next(n);
			}
			return a;
		}

		static void Show(int[] list)
		{
			foreach (var n in list)
			{
				Console.Write(n + " ");
			}
			Console.WriteLine();
		}

		static int[] Stat(int[] list)
		{
			int[] a = new int[list.Length];
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = 0;
			}
			for (int n = 0; n < list.Length; n++)
			{
				a[list[n]]++;
			}
			return a;
		}

		static void ShowStat(int[] list)
		{
			for (int i = 0; i < list.Length; i++)
			{
				Console.WriteLine($"{i} xuat hien {list[i]} lan");
			}
		}
	}
}
