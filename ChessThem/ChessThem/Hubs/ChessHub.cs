using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace ChessThem.Hubs
{
	[HubName("chessHub")]
	public class ChessHub : Hub
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
	}
}
