using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessThem.ChessStuff
{
	public static class Game
	{
		private static Board Board { get; set; }
		private static MoveValidator MoveValidator { get; set; }

		public static bool TryMove(Position from, Position to)
		{
			if (MoveValidator.IsMoveValid(from, to))
			{
				Board[to] = Board[from];
				Board[from] = null;

				return true;
			}

			return false;
		}

		public static void Start()
		{
			Board = Board.Instance;
			Board.Initialize();

			MoveValidator = MoveValidator.Instance;
			MoveValidator.Board = Board;
			MoveValidator.Initialize();
		}
	}
}