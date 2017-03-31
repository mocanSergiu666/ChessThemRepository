using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace ChessThem.Configurations
{
	public static class Configurator
	{
		public static void ConfigureAndRegisterJsonSerializer()
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.ContractResolver = new SignalRContractResolver();
			var jsonSerializer = JsonSerializer.Create(jsonSerializerSettings);
			GlobalHost.DependencyResolver.Register(typeof(JsonSerializer), () => jsonSerializer);
		}
	}
}