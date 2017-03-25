using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessThem.ChessStuff
{
	public class BoardCell
	{
		public Position Position { get; set; }
		public Piece Piece { get; set; }
	}
}