using System;

namespace Bai1._5_ChiaMangTyLe1_1
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Run(10);
				Console.Write("\nBam phim Enter de tiep tuc, bam phim T de thoat: ");
			} while (Console.ReadLine() == "");
		}

		private static void Run(int n)
		{
			int[] a = new int[n];
			Gen(a, n);
			Print(a, n);
			int t = 0, d = Chia(a, n, ref t);
			if (d < 0)
				Console.WriteLine("\nKhong chia duoc");
			else if (KiemTra(a, n, d))
			{
				Console.WriteLine("\nDoan thu nhat: 1..{0} ", d);
				Console.WriteLine("\nDoan thu hai: {0}..{1} ", d + 1, n);
			}
			else
				Console.WriteLine("\nLoi giai sai!");
		}

		/// <summary>
		/// Kiem tra sum(a[1..d]) == sum(a[d+1..n])
		/// </summary>
		/// <param name="a"></param>
		/// <param name="n"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		private static bool KiemTra(int[] a, int n, int d)
		{
			if (d < 0 || d >= n)
				return false;
			int t = 0;
			for (int i = 0; i < d; i++)
				t += a[i];
			for (int i = d; i < n; i++)
				t -= a[i];
			return t == 0;
		}

		private static int Chia(int[] a, int n, ref int t)
		{
			int sum = 0; // sum = tong(a[1..n])
			for (int i = 0; i < n; i++)
				sum += a[i];
			if (sum % 2 != 0)
				return -1;
			t = sum / 2;
			int tr = 0;
			for (int i = 0; i < n; i++)
			{
				tr += a[i];
				if (tr == t)
					return i + 1;
			}
			return -1;
		}

		private static void Print(int[] a, int n)
		{
			foreach (var x in a)
			{
				Console.Write($"{x}\t");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Sinh ngau nhien n so ghi vao mang a
		/// </summary>
		/// <param name="a"></param>
		/// <param name="n"></param>
		private static void Gen(int[] a, int n)
		{
			Random random = new Random();
			if (random.Next(2) == 0)
			{
				// 1/2 so test la vo nghiem
				for (int i = 0; i < n; i++)
					a[i] = random.Next(n);
				return;
			}
			int d = random.Next(n / 2) + 1; // Diem chia
			int t = 0;
			// Sinh doan a[0..d-1]
			for (int i = 0; i < d; i++)
			{
				a[i] = random.Next(n);
				t += a[i];
			}
			int n1 = n - 1;
			// Sinh doan a[d..n-1]
			for (int i = d; i < n1; i++)
			{
				a[i] = random.Next(t);
				t -= a[i];
			}
			a[n - 1] = t; // Phan tu cuoi
		}
	}
}
