using System;
using System.IO;
using System.Text;

namespace Bai3._1_BangMaASCII
{
	class Program
	{
		static void Main(string[] args)
		{
			string filename = "ASCII.txt";
			StreamWriter writer = new(filename, false, Encoding.UTF8);
			for (int i = 0; i < 128; i++)
			{
				writer.WriteLine($"{i}: {(char)i}");
			}
			writer.Close();
			Console.WriteLine(File.ReadAllText(filename));
			Console.ReadLine();
		}
	}
}
