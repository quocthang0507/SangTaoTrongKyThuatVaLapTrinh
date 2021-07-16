using System;
using System.IO;

namespace Bai2._7_SinhNgauNhienTepCapSoCong
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "Data.txt";
			GenToFile(filename, 50);
			Show(filename);
			Console.ReadLine();
		}

		static void Show(string fn)
		{
			Console.WriteLine(File.ReadAllText(fn));
		}

		static void GenToFile(string filename, int n)
		{
			StreamWriter writer = File.CreateText(filename);
			Random random = new Random();
			int s = random.Next(n), d = random.Next(10) + 1;
			for (int i = 0; i < n; ++i)
			{
				writer.Write(s + " ");
				if (i % 20 == 19) writer.WriteLine();
				s += d;
			}
			if (n % 20 != 19) writer.WriteLine();
			writer.Close();
		}
	}
}
