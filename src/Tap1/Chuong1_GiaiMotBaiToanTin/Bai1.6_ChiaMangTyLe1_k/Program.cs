using System;

namespace Bai1._6_ChiaMangTyLe1_k
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Run(10, 3);
				Console.Write("\nBam phim bat ky de tiep tuc, bam phim T de thoat: ");
			} while (Console.ReadLine() != "T");
		}

		private static void Run(int n, int k)
		{
			if (n < 0 || n > 1000000 || k < 1)
				return;
			int[] a = Gen(n, k);
			Print(a);
			int d = Chia(a, k);
			if (d < 0)
				Console.WriteLine("\nVo nghiem");
			else
				Console.WriteLine("\n" + Test(a, d, k));
		}

		/// <summary>
		/// Kiem tra k * sum(a[1..d]) = sum(a[d+1..n])?
		/// </summary>
		/// <param name="a"></param>
		/// <param name="d"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		private static bool Test(int[] a, int d, int k)
		{
			Console.WriteLine($"\n\nTest, k = {k}, diem chia = {d}");
			int t1 = 0, t2 = 0;
			for (int i = 0; i < d; i++)
			{
				t1 += a[i];
			}
			for (int i = d; i < a.Length; i++)
			{
				t2 += a[i];
			}
			Console.WriteLine($"Sum1 = {t1}, sum2 = {t2}");
			return (t1 == k * t2 || t2 == k * t1);
		}

		private static int Chia(int[] a, int k)
		{
			int t = 0;
			foreach (var x in a)
			{
				t += x;
			}
			if (t % (k + 1) != 0)
				return -1;
			int t1 = t / (k + 1), t2 = t - t1, tr = 0;
			for (int i = 0; i < a.Length; i++)
			{
				tr += a[i];
				if (tr == t1 || tr == t2)
					return i + 1;
			}
			return -1;
		}

		private static void Print(int[] a)
		{
			Console.WriteLine();
			Console.WriteLine(new string('=', a.Length * 5));
			foreach (var x in a)
			{
				Console.Write($"{x}    ");
			}
			Console.WriteLine();
		}

		private static int[] Gen(int n, int k)
		{
			Random random = new Random();
			int[] a = new int[n];
			if (random.Next(2) == 0)
			{
				// Khoang 1/2 so test la vo nghiem
				for (int i = 0; i < n; i++)
					a[i] = random.Next(n);
			}
			int d = random.Next(n / 2) + 1; // Diem chia
			int t = 0, d1 = d - 1;
			for (int i = 0; i < d1; i++)
			{
				a[i] = random.Next(n);
				t += a[i];
			}
			if (random.Next(2) == 0)
				// Doan dau a[1..d] gap k lan doan cuoi a[d+1..n]
				a[d1] += (k - 1) * t;
			else
				// Doan cuoi gap k lan doan dau
				t *= k;
			int n1 = n - 1;
			for (int i = d; i < n1; i++)
			{
				a[i] = random.Next(t);
				t -= a[i];
			}
			a[n1] = t;
			return a;
		}
	}
}
