using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessThem.ChessStuff
{
	[Serializable]
	public class OutOfBoardException : Exception
	{
		public OutOfBoardException(Position lastPosition, string message) : base(message)
		{
			LastPosition = lastPosition;
		}

		public Position LastPosition { get; }
	}
}