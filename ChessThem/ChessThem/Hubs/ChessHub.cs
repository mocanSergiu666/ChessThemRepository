using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using ChessThem.ChessStuff;

namespace ChessThem.Hubs
{
	[HubName("chessHub")]
	public class ChessHub : Hub<IClientHub>
	{
		public override Task OnConnected()
		{
			return base.OnConnected();
		}

		public override Task OnReconnected()
		{
			return base.OnReconnected();
		}

		public override Task OnDisconnected(bool stopCalled)
		{
			return base.OnDisconnected(stopCalled);
		}

		[HubMethodName("tryMove")]
		public Task<bool> TryMove(Position from, Position to)
		{
			return new Task<bool>(() => true);// Game.TryMove(from, to);
		}

		[HubMethodName("sendMessage")]
		public void SendMessage(string message)
		{
			Clients.All.RecieveMessage("ciuvac", message);
		}
	}
}
