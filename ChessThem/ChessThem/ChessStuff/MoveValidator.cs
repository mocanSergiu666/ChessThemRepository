using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessThem.ChessStuff
{
	public class MoveValidator
	{
		private static MoveValidator _instance;
		private static Board _board;

		static MoveValidator()
		{
			_instance = new MoveValidator();
		}

		private MoveValidator()
		{

		}

		public static MoveValidator Instance
		{
			get
			{
				return _instance;
			}
		}

		public Board Board
		{
			set
			{
				_board = value;
			}
		}

		public bool IsMoveValid(Position from, Position to)
		{
			return true;
			// TODO
		}

		public void Initialize()
		{
			// TODO
		}
	}
}