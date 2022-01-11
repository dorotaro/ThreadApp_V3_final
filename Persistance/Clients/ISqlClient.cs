namespace Persistance.Clients
{
	public interface ISqlClient
	{
		Task Execute<T>(List<string> queries, object param);

		Task<IEnumerable<T>> Query<T>(string query, object param);
	}
}
