using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ChessThem.ChessStuff
{
	public class Board
	{
		public const int Size = 8;
		private static Board _instance;
		private static List<BoardCell> _initialBoardState;
		private static Piece[,] _board;

		static Board()
		{
			_instance = new Board();

			using (StreamReader streamReader = new StreamReader(Utilities.GetInitialBoardStateStream()))
			{
				string initialBoardStateJson = streamReader.ReadToEnd();
				_initialBoardState = JsonConvert.DeserializeObject<List<BoardCell>>(initialBoardStateJson);
				Instance.Initialize();
			}
		}

		private Board()
		{
			_board = new Piece[Size, Size];
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

		public static List<BoardCellState> State
		{
			get
			{
				var state = new List<BoardCellState>(32);

				for (int i = 0; i < _board.GetLength(0); i++)
					for (int j = 0; j < _board.GetLength(1); j++)
					{
						var piece = _board[i, j];
						if (piece != null)
							state.Add(new BoardCellState
							{
								PieceColor = piece.Color.ToString(),
								PieceType = piece.Type.ToString(),
								Position = new Position
								{
									X = (XCoordinate)i,
									Y = (YCoordinate)j
								}
							});
					}

				return state;
			}
		}
	}
}