using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cursor_A
{
	internal class Cursor
	{
		static Random rnd = new Random();
		static ConsoleColor[] colors = new ConsoleColor[] {
		ConsoleColor.DarkBlue,
			ConsoleColor.DarkGreen,
			ConsoleColor.DarkCyan,
			ConsoleColor.DarkMagenta,
			ConsoleColor.DarkYellow,
			ConsoleColor.Magenta,
			ConsoleColor.DarkRed,
			ConsoleColor.DarkGray,
			ConsoleColor.Gray,
			ConsoleColor.Blue,
			ConsoleColor.Green,
			ConsoleColor.Cyan,
			ConsoleColor.Magenta,
			ConsoleColor.Yellow
		};
		static Direction[] dirs = new Direction[] { Direction.Up, Direction.Right, Direction.Down, Direction.Left };
		public Position Pos { get; private set; }
		public Position OldPos { get; private set; }
		public Direction Dir { get; private set; }
		public ConsoleColor Color { get; }
		public char Face { get; }
		private int step;
		private MapObject[,] map;

		public Cursor(MapObject[,] _map, Position _start)
		{
			map = _map;
			Face = '█';
			Color = colors[rnd.Next(colors.Length)];
			Dir = dirs[rnd.Next(dirs.Length)];
			Pos = _start;
			OldPos = Pos;
			step = rnd.Next(2, 15);

		}
		public void Move(Position nP)
		{			
			if (step == 0)
			{
				ChangeDirection();
				step = rnd.Next(2, 15);
			}
			else
			{
				OldPos = Pos;
				step--;
				Pos = nP;
			}
		}
		public void ChangeDirection()
		{
			Dir = dirs[rnd.Next(dirs.Length)];
		}
		public void ChangeDirection(Direction act)
		{
			List<Direction> directions = new List<Direction>(dirs);
			directions.Remove(act);
			Dir = directions[rnd.Next(directions.Count)];
		}

		internal Position NextStep()
		{
			Position result = new Position();
			switch (Dir)
			{
				case Direction.Up:
					result = new Position() { X = Pos.X, Y = Pos.Y - 1 };
					break;
				case Direction.Right:
					result = new Position() { X = Pos.X + 1, Y = Pos.Y };
					break;
				case Direction.Down:
					result = new Position() { X = Pos.X, Y = Pos.Y + 1 };
					break;
				case Direction.Left:
					result = new Position() { X = Pos.X - 1, Y = Pos.Y };
					break;
				default:
					break;
			}
			return result;
		}
	}
}
