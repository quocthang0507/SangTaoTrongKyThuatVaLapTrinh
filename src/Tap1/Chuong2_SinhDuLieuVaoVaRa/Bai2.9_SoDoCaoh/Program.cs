using System;
using System.IO;

namespace Bai2._9_SoDoCaoh
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "result.txt";
			int h = 10;
			Console.WriteLine("\nFile " + filename);
			Console.WriteLine("h = " + h);
			int d = Gen(filename, h);
			Read(filename, d);
			Console.ReadLine();
		}

		static void Read(string filename, int d)
		{
			Console.WriteLine("\nTong cong " + d + " so");
			Console.WriteLine(File.ReadAllText(filename));
		}

		static int Gen(string filename, int h)
		{
			int a, b, mina, maxa, minb, maxb, bc, x, y, d = 0;
			StreamWriter writer = File.CreateText(filename);
			mina = h <= 18 ? 0 : h - 18;
			maxa = h <= 9 ? h : 9;
			for (a = mina; a <= maxa; a++)
			{
				x = 100 * a;
				bc = h - a;
				minb = bc <= 9 ? 0 : bc - 9;
				maxb = bc >= 9 ? 9 : bc;
				for (b = minb; b <= maxb; b++)
				{
					d++;
					y = x + 10 * b + (bc - b);
					writer.Write(y + " ");
					if (d % 10 == 0)
						writer.WriteLine();
				}
			}
			writer.Close();
			return d;
		}
	}
}
