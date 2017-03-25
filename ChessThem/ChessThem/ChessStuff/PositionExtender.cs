using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessThem.ChessStuff
{
	public static class PositionExtender
	{
		public static Position Up(this Position position)
		{
			if ((int)position.Y + 1 == Board.Size)
				throw new OutOfBoardException(position, "Move up not possible.");
			
			return new Position
			{
				X = position.X,
				Y = (YCoordinate)((int)position.Y + 1)
			};
		}

		public static Position Down(this Position position)
		{
			if ((int)position.Y - 1 == -1)
				throw new OutOfBoardException(position, "Move down not possible.");

			return new Position
			{
				X = position.X,
				Y = (YCoordinate)((int)position.Y - 1)
			};
		}

		public static Position Left(this Position position)
		{
			if ((int)position.X - 1 == -1)
				throw new OutOfBoardException(position, "Move left not possible.");

			return new Position
			{
				X = (XCoordinate)((int)position.X - 1),
				Y = position.Y
			};
		}

		public static Position Right(this Position position)
		{
			if ((int)position.X + 1 == Board.Size)
				throw new OutOfBoardException(position, "Move right not possible.");

			return new Position
			{
				X = (XCoordinate)((int)position.X + 1),
				Y = position.Y
			};
		}

		public static Position UpLeft(this Position position)
		{
			if ((int)position.Y + 1 == Board.Size || (int)position.X - 1 == -1)
				throw new OutOfBoardException(position, "Move up left not possible.");

			return new Position
			{
				X = (XCoordinate)((int)position.X - 1),
				Y = (YCoordinate)((int)position.Y + 1)
			};
		}

		public static Position UpRight(this Position position)
		{
			if ((int)position.Y + 1 == Board.Size || (int)position.X + 1 == Board.Size)
				throw new OutOfBoardException(position, "Move up right not possible.");

			return new Position
			{
				X = (XCoordinate)((int)position.X + 1),
				Y = (YCoordinate)((int)position.Y + 1)
			};
		}

		public static Position DownLeft(this Position position)
		{
			if ((int)position.Y - 1 == -1 || (int)position.X - 1 == -1)
				throw new OutOfBoardException(position, "Move down left not possible.");

			return new Position
			{
				X = (XCoordinate)((int)position.X - 1),
				Y = (YCoordinate)((int)position.Y - 1)
			};
		}

		public static Position DownRight(this Position position)
		{
			if ((int)position.Y - 1 == -1 || (int)position.X + 1 == Board.Size)
				throw new OutOfBoardException(position, "Move down right not possible.");

			return new Position
			{
				X = (XCoordinate)((int)position.X + 1),
				Y = (YCoordinate)((int)position.Y - 1)
			};
		}
	}
}