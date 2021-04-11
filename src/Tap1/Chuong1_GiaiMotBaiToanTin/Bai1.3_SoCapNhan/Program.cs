using System;
using System.Collections;

namespace Bai1._3_SoCapNhan
{
	class Program
	{
		static void Main(string[] args)
		{
			Show(Find());
			Console.WriteLine("\nFinish!");
			Console.ReadKey();
		}

		private static ArrayList Find()
		{
			ArrayList s = new ArrayList();
			int[] cd = { 0, 3, 2, 1, 1, 1, 1, 1, 1, 1 };
			for (int a = 1; a <= 9; a++)
			{
				for (int d = 1; d <= cd[a]; d++)
				{
					s.Add(a * (100 + 10 * d + d * d));
				}
			}
			return s;
		}

		static void Show(ArrayList list)
		{
			foreach (var n in list)
			{
				Console.Write(n + " ");
			}
			Console.WriteLine();
		}
	}
}
