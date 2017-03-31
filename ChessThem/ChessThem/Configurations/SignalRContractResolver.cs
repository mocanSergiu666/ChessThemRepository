using Microsoft.AspNet.SignalR.Infrastructure;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace ChessThem
{
	public class SignalRContractResolver : IContractResolver
	{
		private readonly Assembly _assembly;
		private readonly IContractResolver _camelCaseContractResolver;
		private readonly IContractResolver _defaultContractResolver;

		public SignalRContractResolver()
		{
			_defaultContractResolver = new DefaultContractResolver();
			_camelCaseContractResolver = new CamelCasePropertyNamesContractResolver();
			_assembly = typeof(Connection).Assembly;
		}

		public JsonContract ResolveContract(Type type)
		{
			if (type.Assembly.Equals(_assembly))
			{
				return _defaultContractResolver.ResolveContract(type);
			}

			return _camelCaseContractResolver.ResolveContract(type);
		}
	}
}
