using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cursor_A
{
	internal class Program
	{
		static Random rnd = new Random();
		static Size size;
		static Position offset;
		static List<Cursor> cursors = new List<Cursor>();
		static MapObject[,] map;
		static Dictionary<MapObject, char> chars = new Dictionary<MapObject, char>()
		{
			{MapObject.Wall,'█' },
			{MapObject.Empty,' ' }
		};
		static Dictionary<MapObject, ConsoleColor> colors = new Dictionary<MapObject, ConsoleColor>()
		{
			{MapObject.Wall,ConsoleColor.White },
			{ MapObject.Empty, ConsoleColor.Black}
		};
		static Position test;
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			size = new Size() { Width = 55, Height = 25 };
			map = new MapObject[size.Width, size.Height];
			offset = new Position() { X = 1, Y = 1 };

			CreateWalls();
			DrawMap();
			for (int i = 0; i < 20; i++)
			{
				cursors.Add(new Cursor(map, GetRandomPosition()));
			}

			foreach (Cursor cursor in cursors)
			{
				Draw(cursor);
			}


			do
			{
				foreach (Cursor cursor in cursors)
				{
					test = cursor.NextStep();
					switch (map[test.X, test.Y])
					{
						case MapObject.Empty:
							cursor.Move(test);
							break;
						case MapObject.Wall:
							cursor.ChangeDirection(cursor.Dir);
							break;
						default:
							break;
					}
					Draw(cursor);
					Draw(cursor.OldPos, ' ', ConsoleColor.Black);
				}

				System.Threading.Thread.Sleep(70);
			} while (true);
			//----------------------------
			Console.ReadKey();
		}

		private static Position GetRandomPosition()
		{
			Position result;
			do
			{
				result = new Position() { X = rnd.Next(1, size.Width - 1), Y = rnd.Next(1, size.Height - 1) };
			} while (map[result.X, result.Y] != MapObject.Empty);
			return result;
		}

		private static void CreateWalls()
		{
			for (int y = 0; y < size.Height; y++)
			{
				for (int x = 0; x < size.Width; x++)
				{
					if (x == 0 || y == 0 || x == size.Width - 1 || y == size.Height - 1)
					{
						map[x, y] = MapObject.Wall;
					}
					else
					{
						map[x, y] = MapObject.Empty;
					}
				}
			}

			AddInnerWalls();
		}

		private static void AddInnerWalls()
		{
			int w = size.Width;
			int h = size.Height;

			for (int y = 4; y < h - 4; y++)
			{
				for (int x = 4; x < w - 4; x++)
				{
					if ((x == 4 || x == w - 5 || y == 4 || y == h - 5) ||
					    (x == 10 || x == w - 11 || y == 10 || y == h - 11))
					{
						map[x, y] = MapObject.Wall;
					}
				}
			}

			OpenGaps();
		}

		private static void OpenGaps()
		{
			int[] gapPositions = { 4, 10, size.Width - 5, size.Width - 11 };

			foreach (int pos in gapPositions)
			{
				map[pos, size.Height / 2] = MapObject.Empty;
				map[size.Width / 2, pos] = MapObject.Empty;
			}
		}

		private static void Draw(Cursor c)
		{
			Console.SetCursorPosition(offset.X + c.Pos.X, offset.Y + c.Pos.Y);
			Console.ForegroundColor = c.Color;
			Console.Write(c.Face);
		}
		private static void Draw(Position p, char c, ConsoleColor color)
		{
			Console.SetCursorPosition(offset.X + p.X, offset.Y + p.Y);
			Console.ForegroundColor = color;
			Console.Write(c);
		}
		private static void DrawMap()
		{
			for (int y = 0; y < size.Height; y++)
			{
				for (int x = 0; x < size.Width; x++)
				{
					Draw(new Position() { X = x, Y = y }, chars[map[x, y]], colors[map[x, y]]);
				}
			}
		}
	}

	public struct Size
	{
		public int Width { get; set; }
		public int Height { get; set; }
	}
	public struct Position
	{
		public int X { get; set; }
		public int Y { get; set; }
	}
	public enum Direction { Up, Right, Down, Left }
	public enum MapObject { Empty, Wall }
}
