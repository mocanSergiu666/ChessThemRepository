using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChessThem.Startup))]
namespace ChessThem
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
			
			app.MapSignalR("/chesssignalr", new HubConfiguration()
			{
				EnableDetailedErrors = true,
				EnableJavaScriptProxies = true,
				EnableJSONP = false
			});
		}
	}
}
