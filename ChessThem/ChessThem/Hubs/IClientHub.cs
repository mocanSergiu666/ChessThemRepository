namespace ChessThem.Hubs
{
	public interface IClientHub
	{
		void RecieveMessage(string sender, string message);
	}
}
