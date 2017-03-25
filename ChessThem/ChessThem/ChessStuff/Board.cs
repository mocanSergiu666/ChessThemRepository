using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ChessThem.ChessStuff
{
	public class Board
	{
		private const int _size = 8;
		private static Board _instance;
		private static List<BoardCell> _initialBoardState;
		private static Piece[,] _board;

		static Board()
		{
			_instance = new Board();
			
			using (StreamReader streamReader = new StreamReader("InitialBoardState.json"))
			{
				string initialBoardStateJson = streamReader.ReadToEnd();
				_initialBoardState = JsonConvert.DeserializeObject<List<BoardCell>>(initialBoardStateJson);
			}
		}

		private Board()
		{
			_board = new Piece[_size, _size];
		}

		public static Board Instance
		{
			get
			{
				return _instance;
			}
		}

		public Piece this[Position position]
		{
			get
			{
				return _board[(int)position.X, (int)position.Y];
			}

			set
			{
				_board[(int)position.X, (int)position.Y] = value;
			}
		}

		public void Initialize()
		{
			Clear();

			foreach (BoardCell boardCell in _initialBoardState)
			{
				this[boardCell.Position] = boardCell.Piece;
			}
		}

		private void Clear()
		{
			for (int i = 0; i < _board.GetLength(0); i++)
				for (int j = 0; j < _board.GetLength(1); j++)
					_board[i, j] = null;
		}
	}
}