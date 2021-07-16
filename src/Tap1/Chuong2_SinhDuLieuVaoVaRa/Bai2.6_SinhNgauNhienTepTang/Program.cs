using System;
using System.IO;

namespace Bai2._6_SinhNgauNhienTepTang
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "Data.txt";
			GenToFile(filename, 20);
			Show(filename);
			Console.ReadKey();
		}

		static void Show(string filename)
		{
			Console.WriteLine(File.ReadAllText(filename));
		}

		static void GenToFile(string filename, int n)
		{
			StreamWriter writer = new StreamWriter(filename);
			Random random = new Random();
			int x = random.Next(10);
			for (int i = 0; i < n; i++)
			{
				writer.Write(x + " ");
				// Moi dong 20 so
				if (i % 20 == 19)
					writer.WriteLine();
				x += random.Next(10);
			}
			if (n % 20 != 19)
				writer.WriteLine();
			writer.Close();
		}
	}
}
