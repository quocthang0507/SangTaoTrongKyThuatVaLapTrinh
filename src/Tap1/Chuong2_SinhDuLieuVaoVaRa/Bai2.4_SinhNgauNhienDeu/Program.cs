using System;

namespace Bai2._4_SinhNgauNhienDeu
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int n, k, t;
			do
			{
				n = r.Next(30) + 1;
				t = r.Next(30) + 1;
				k = r.Next(8) + 1;
				Console.WriteLine($"\n n = {n}, k = {k}, t = {t}");
				Print(Gen(n, k, t));
				Console.Write("Bam return de tiep tuc...");
			} while (Console.ReadLine() == "");
		}

		private static void Print(int[] arr)
		{
			foreach (var a in arr)
			{
				Console.Write($"{a}\t");
			}
			Console.WriteLine();
		}

		static int[] Gen(int n, int k, int t)
		{
			if (k < 1 || k > n)
				return new int[0];
			Random r = new Random();
			int[] a = new int[n];
			int s = n / k; // So phan tu trong mot doan
			int i = 0;
			for (int j = 0; j < k; j++)
			{
				// Sinh doan thu j
				int tr = t;
				int endp = r.Next(s);
				for (int p = 0; p < endp; p++, i++)
				{
					a[i] = r.Next(tr);
					tr -= a[i];
				}
				a[i++] = tr;
			}
			// Dien so 0 cho du n phan tu
			for (; i < n; i++)
			{
				a[i] = 0;
			}
			return a;
		}
	}
}
