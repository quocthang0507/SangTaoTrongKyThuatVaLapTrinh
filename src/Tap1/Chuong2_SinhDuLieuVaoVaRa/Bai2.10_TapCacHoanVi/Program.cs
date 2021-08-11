using System;
using System.IO;

namespace Bai2._10_TapCacHoanVi
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "HoanVi.txt";
			int d = Gen(filename, 5);
			Print(filename, d);
			Console.ReadLine();
		}

		static void Print(string filename, int d)
		{
			Console.WriteLine("\nTong cong " + d + " so");
			Console.WriteLine(File.ReadAllText(filename));
		}

		static bool Next(int[] a)
		{
			int i, j, t, n = a.Length - 1;
			for (i = n - 1; a[i] > a[i + 1]; i--) ;
			if (i == 0)
				return false;
			for (j = n; a[j] < a[i]; j--) ;
			Swap(ref a, i, j);
			for (i++, j = n; i < j; i++, j--)
			{
				Swap(ref a, i, j);
			}
			return true;
		}

		static void Swap(ref int[] a, int i, int j)
		{
			int t = a[i];
			a[i] = a[j];
			a[j] = t;
		}

		static int Gen(string filename, int n)
		{
			if (n < 1 || n > 9)
				return 0;
			int d = 0;
			StreamWriter writer = File.CreateText(filename);
			int[] a = new int[n + 1];
			for (int i = 0; i <= n; i++)
				a[i] = i;
			do
			{
				for (int i = 1; i <= n; i++)
					writer.Write(a[i] + " ");
				writer.WriteLine();
				d++;
			} while (Next(a));
			writer.Close();
			return d;
		}
	}
}
