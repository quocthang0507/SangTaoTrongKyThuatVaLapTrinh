using System;

namespace Bai3._4_TroChoi15
{
	class Program
	{
		const int scot = 20; // Toa do cot goc
		const int sdong = 8; // Toa do dong goc
		const int dcot = 5; // Kh cach giua 2 o tren dong
		const int ddong = 2; // Khoang cach dongconst int dd = 4; // ban co kich thuoc 4 X 4
		const int dd = 4; // ban co kich thuoc 4 X 4
		const int dd1 = dd - 1;
		const int LEN = 1;
		const int XUONG = 2;
		const int PHAI = 3;
		const int TRAI = 4;
		const int END = 5;
		const int ESC = 6;
		const string BL = " ";// dau cach
		public static int[,] a = new int[dd, dd];
		public static int[,] b = new int[dd, dd];
		public static int cot = dd1; // toa do o trong
		public static int dong = dd1;

		static void Main(string[] args)
		{
			Init();
			Play();
		}

		public static void Play()
		{
			int d = 0;
#pragma warning disable CA1416 // Validate platform compatibility
			if (Console.CursorVisible)
#pragma warning restore CA1416 // Validate platform compatibility
			{
#pragma warning disable CA1416 // Validate platform compatibility
				Console.CursorVisible = !Console.CursorVisible;
#pragma warning restore CA1416 // Validate platform compatibility
			}

			Console.SetCursorPosition(1, 1);
			Console.Write("So buoc: ");
			int coty = Console.CursorTop;
			int dongx = Console.CursorLeft;
			Console.SetCursorPosition(dongx, coty);
			Console.Write(d);
			int k;
			do
			{
				VeO(dong, cot);
				if (Sanhab())
				{
					Console.SetCursorPosition(dongx + 2,
					coty);
					Console.Write(" Chuc mung Thanh Cong !!!");
					Console.ReadLine();
					return;
				}
				k = GetKey(); 
				++d;
				Console.SetCursorPosition(dongx, coty);
				Console.Write(" ");
				Console.SetCursorPosition(dongx, coty);
				Console.Write(d);
				switch (k)
				{
					// case LEN: // Day quan duoi o trong LEN
					case XUONG: // Day quan duoi o trong LEN
						if (dong < dd1)
						{
							a[dong, cot] = a[dong + 1, cot]; VeO(dong, cot);
							++dong; a[dong, cot] = 0;
							VeO(dong, cot);
						}
						break;
					// case XUONG://Day quan tren o trong XUONG
					case LEN://Day quan tren o trong XUONG
						if (dong > 0)
						{
							a[dong, cot] = a[dong - 1, cot];
							VeO(dong, cot);
							--dong; a[dong, cot] = 0;
							VeO(dong, cot);
						}
						break;
					// case PHAI: // Day quan TRAI o trong sang
					case TRAI: // Day quan TRAI o trong sang
						if (cot > 0)
						{
							a[dong, cot] = a[dong, cot - 1];
							VeO(dong, cot);
							--cot; a[dong, cot] = 0;
							VeO(dong, cot);
						}
						break;
					// case TRAI: // Day quan PHAI o trong sang
					case PHAI: // Day quan PHAI o trong sang
						if (cot < dd1)
						{
							a[dong, cot] = a[dong, cot + 1];
							VeO(dong, cot);
							++cot; a[dong, cot] = 0;
							VeO(dong, cot);
						}
						break;
				}
			} while (k != ESC);
		}

		public static void Gotoij(int i, int j)
		{
			Console.SetCursorPosition(scot + dcot * j,
			sdong + ddong * i);
		}

		public static void VeO(int i, int j)
		{
			int dong = sdong + ddong * i;
			int cot = scot + dcot * j;
			Console.SetCursorPosition(cot, dong);
			Console.Write(" ");
			Console.SetCursorPosition(cot, dong);
			if (a[i, j] == 0)
			{
				Console.BackgroundColor =
				ConsoleColor.Blue;
				Console.Write("[" + BL + BL + "]");
				Console.BackgroundColor = ConsoleColor.Black;
			}
			else if (a[i, j] < 10)
				Console.Write("[" + BL + a[i, j] + "]");
			else Console.Write("[" + a[i, j] + "]");
		}

		// so sanh hai cau hinh a va b
		public static bool Sanhab()
		{
			for (int i = 0; i < dd; ++i)
				for (int j = 0; j < dd; ++j)
					if (a[i, j] != b[i, j]) return false;
			return true;
		}

		// Dao ngau nhien maxk lan
		public static void DaoNgauNhien(int maxk)
		{
			Random r = new();
			for (; Sanhab();) // Dao den khi a != b
			{
				for (int k = 0; k < maxk; ++k)
				{
					switch (r.Next(4) + 1)
					{
						case LEN:
							// Day quan duoi o trong LEN
							if (dong < dd1)
							{
								a[dong, cot] = a[dong + 1, cot];
								++dong; a[dong, cot] = 0;
							}
							break;
						case XUONG:
							// Day quan tren o trong XUONG
							if (dong > 0)
							{
								a[dong, cot] = a[dong - 1, cot];
								--dong; a[dong, cot] = 0;
							}
							break;
						case PHAI:
							// Day quan TRAI o trong sang
							if (cot > 0)
							{
								a[dong, cot] = a[dong, cot - 1];
								--cot; a[dong, cot] = 0;
							}
							break;
						case TRAI: // Day quan PHAI o trong sang
							if (cot < dd1)
							{
								a[dong, cot] = a[dong, cot + 1];
								++cot; a[dong, cot] = 0;
							}
							break;
					} // switch
				} // for k
			} // for sanh
		}

		public static void VeBanCo()
		{
			for (int i = 0; i < dd; ++i)
				for (int j = 0; j < dd; ++j)
					VeO(i, j);
		}

		public static void Init()
		{
			// Khoi tri ban co a.
			// Ban co b dung de doi sanh.
			int k = 1;
			for (int i = 0; i < dd; ++i)
				for (int j = 0; j < dd; ++j)
					b[i, j] = a[i, j] = k++;
			b[dd1, dd1] = a[dd1, dd1] = 0;
			dong = dd1; cot = dd1;
			DaoNgauNhien(200);
			VeBanCo();
		}

		public static int GetKey()
		{
			ConsoleKeyInfo k;
			k = Console.ReadKey(true);
			char c = k.KeyChar;
			if (char.IsControl(c))
			{
				switch (k.Key)
				{
					case ConsoleKey.RightArrow: return PHAI;
					case ConsoleKey.LeftArrow: return TRAI;
					case ConsoleKey.DownArrow: return XUONG;
					case ConsoleKey.UpArrow: return LEN;
					case ConsoleKey.End: return END;
					case ConsoleKey.Escape: return ESC;
				}
			}
			return 0;
		}
	}
}
