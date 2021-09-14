using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._2_TuLoKho
{
	class BoBai
	{
		private readonly char CO = (char)3;
		private readonly char RO = (char)4;
		private readonly char NHEP = (char)5;
		private readonly char PIC = (char)6;

		// Kich thuoc quan bai
		const int DX = 12;
		const int DY = 9;

		// Khoang cach giua hai dong
		const int TY = 1;
		const int SOQUAN = 13;

		private readonly string[] MauDong = {
			"00100",
			"01010",
			"10101",
			"20002",
			"20102",
			"20202",
			"20302",
			"21212",
			"30303",
			"22222",
			"22322",
			"23232",
			"23332"
		};
		private readonly string[] Nhan = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

		/// <summary>
		/// Viet chuoi s tai cot x, dong y
		/// </summary>
		/// <param name="s"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>		
		private static void WriteAt(string s, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(s);
		}

		/// <summary>
		/// Ve 5 dong trong quan bai
		/// </summary>
		/// <param name="q"></param>
		/// <param name="s"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private static void Lines(char q, string s, int x, int y)
		{
			const string BL = " ";
			string qs = q.ToString();
			x += 3;
			for (int i = 0; i < 5; i++)
			{
				y += TY;
				Console.SetCursorPosition(x, y);
				switch (s[i])
				{
					case '1':
						Console.WriteLine(BL + BL + qs + BL + BL);
						break;
					case '2':
						Console.WriteLine(qs + BL + BL + BL + qs);
						break;
					case '3':
						Console.WriteLine(qs + BL + qs + BL + qs);
						break;
					default:
						break;
				}
			}
		}

		/// <summary>
		/// Dat mau nen cho quan bai
		/// </summary>
		/// <param name="m"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private static void Nen(ConsoleColor m, int x, int y)
		{
			string s = new(' ', DX);
			Console.BackgroundColor = m;
			for (int i = 0; i <= DY ; i++)
			{
				WriteAt(s, x + 1, y + i);
			}
		}

		/// <summary>
		/// Ve 1 quan bai kieu q (ro, co, bich, nhep); So n (1..10; 0 = A, 10 = J, 11 = Q, 12 = K)
		/// goc Tay - Bac tai cot x, dong y
		/// </summary>
		/// <param name="q"></param>
		/// <param name="n"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		private void VeQuanBai(char q, int n, int x, int y)
		{
			// Mau chu RO, Co: Mau do,
			// Pic, NHEP: Mau den
			Console.ForegroundColor = (q == RO || q == CO) ? ConsoleColor.Red : ConsoleColor.Black;
			// Dat mau nen quan bai trang
			Nen(ConsoleColor.White, x, y);
			// Ve 5 dong
			Lines(q, MauDong[n], x, y);
			// Viet so o goc tren ben trai
			WriteAt(Nhan[n], x + 2, y);
			// Viet so o goc duoi ben phai
			if (n == 9)
				WriteAt(Nhan[n], x + DX - 2, y + DY);
			else
				WriteAt(Nhan[n], x + DX - 1, y + DY);
		}

		/// <summary>
		/// Ve bo bai tai vi tri x, y
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void Draw(int x, int y)
		{
			int DD = DX + 10;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			for (int i = 0; i < SOQUAN; i++)
			{
				VeQuanBai(RO, i, x, y);
				VeQuanBai(CO, i, x + DD, y);
				VeQuanBai(PIC, i, x + 2 * DD, y);
				VeQuanBai(NHEP, i, x + 3 * DD, y);
				Console.ReadLine();
			}
			Console.ResetColor();
		}
	}
}
