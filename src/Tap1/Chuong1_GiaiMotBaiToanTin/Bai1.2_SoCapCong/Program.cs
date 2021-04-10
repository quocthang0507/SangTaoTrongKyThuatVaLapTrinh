using System;

namespace Bai1._2_SoCapCong
{
	class Program
	{
		static void Main(string[] args)
		{
			Show(Find());
			Console.WriteLine("\nHoan thanh");
			Show(Find2());
			Console.ReadKey();
		}

		static void Show(int[] s)
		{
			foreach (var x in s)
			{
				Console.Write(x + " ");
			}
		}

		static int[] Find()
		{
			int d = 0, x;
			int[] ChuSoLe = { 1, 3, 5, 7, 9 },
			s = new int[25];
			for (int i = 0; i < 5; i++)
			{
				x = 105 * ChuSoLe[i];
				for (int j = 0; j < 5; j++)
				{
					s[d++] = x + 6 * ChuSoLe[j];
				}
			}
			return s;
		}

		static int[] Find2()
		{
			int d = 0;
			int[] s = new int[25];
			for (int a = 1; a <= 9; a++)
			{
				for (int b = 0; b <= 9; b++)
				{
					for (int c = 0; c <= 9; c++)
					{
						if(c %2!=0 && (2 * b == a + c))
						{
							s[d++] = 100 * a + 10 * b + c;
						}
					}
				}
			}
			return s;
		}
	}
}
