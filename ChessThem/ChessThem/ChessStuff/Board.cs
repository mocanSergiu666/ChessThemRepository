using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessThem.ChessStuff
{
	public class Board
	{
		private static Board _instance;

		static Board()
		{
			_instance = new Board();
		}

		private Board()
		{
			_pieces = new Piece[8, 8];
		}

		public static Board Instance
		{
			get
			{
				return _instance;
			}
		}

		private Piece[,] _pieces;

		public Piece this[XCoordinate x, YCoordinate y]
		{
			get
			{
				return _pieces[(int)x, (int)y];
			}

			set
			{
				_pieces[(int)x, (int)y] = value;
			}
		}

		public void Initialize()
		{
			//this[XCoordinate.A, YCoordinate.One] = new Piece
			//{
			//	Color = Color.White,
			//	Type = PieceType.Rook
			//};
			//this[XCoordinate.A, YCoordinate.One] = new Piece
			//{
			//	Color = Color.White,
			//	Type = PieceType.Rook
			//};
		}
	}
}