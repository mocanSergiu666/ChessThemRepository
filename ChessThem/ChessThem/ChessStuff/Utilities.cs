using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ChessThem.ChessStuff
{
	public static class Utilities
	{
		public static Stream GetInitialBoardStateStream()
		{
			return Assembly.GetExecutingAssembly().GetManifestResourceStream("ChessThem.ChessStuff.InitialBoardState.json");
		}
	}
}