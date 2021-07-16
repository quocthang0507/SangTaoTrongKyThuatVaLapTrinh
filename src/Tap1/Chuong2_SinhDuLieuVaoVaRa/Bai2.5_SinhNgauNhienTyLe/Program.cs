using System;

namespace Bai2._5_SinhNgauNhienTyLe
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int n, k;
			do
			{
				Console.WriteLine(new string('=', 50));
				n = random.Next(30) + 2;
				k = random.Next(8) + 1;
				Console.WriteLine($"n = {n}, k = {k}");
				int[] a = new int[n];
				int n1 = Gen(a, n, k);
				Print(a);
				Test(a, n1, k);
				Console.Write("\nBam RETURN de tiep tuc: ");
			} while (Console.ReadLine() == "");
		}

		static void Print(int[] a)
		{
			Console.WriteLine();
			foreach (var x in a)
			{
				Console.Write(x + " ");
			}
			Console.WriteLine();
		}

		static int Gen(int[] a, int n, int k)
		{
			Random random = new Random();
			int i = 0; // phan tu thu i trong a
			int n1 = random.Next(n / 2) + 1; // n1 - so phan tu trong doan 1
			int t1 = 0; // tong doan 1
			for (; i < n1; i++)
			{
				a[i] = random.Next(10);
				t1 += a[i];
			}
			int t2 = k * t1;
			int tt = t1;
			// Xac dinh ngau nhien
			// 0. t2 gap k lan t1, hoac
			// 1. t1 gap k lan t2
			if (random.Next(2) == 1)
			{
				// t1 gap k lan t2
				t1 = t2;
				t2 = tt;
				a[i - 1] += t1 - t2;
			}
			// Sinh doan 2
			for (; i < n; i++)
			{
				a[i] = random.Next(t2);
				t2 -= a[i];
			}
			a[n - 1] += t2;
			return n1;
		}

		static void Test(int[] a, int n1, int k)
		{
			int t1 = 0;
			for (int i = 0; i < n1; i++)
			{
				t1 += a[i];
			}
			Console.WriteLine($"\nDoan thu nhat: sum(a[0..{n1 - 1}]) = {t1}");
			int t2 = 0;
			for (int i = n1; i < a.Length; i++)
			{
				t2 += a[i];
			}
			Console.WriteLine($"\nDoan thu hai: sum(a[{n1}..{a.Length - 1}]) = {t2}");
			if ((t1 == k * t2) || (t2 == k * t1))
			{
				Console.WriteLine("\nDUNG");
			}
			else
			{
				Console.WriteLine("\n SAI");
			}
		}
	}
}
