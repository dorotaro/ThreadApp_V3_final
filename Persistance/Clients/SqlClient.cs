using Dapper;
using MySql.Data.MySqlClient;

namespace Persistance.Clients
{
	public class SqlClient : ISqlClient
	{
		public readonly string _connectionString;

		public SqlClient(string connectionString)
		{
			_connectionString = connectionString;
		}

		public async Task Execute<T>(List<string> queries, object param)
		{
			using var connection = new MySqlConnection(_connectionString);

			connection.Open();

			foreach (var query in queries)
			{
				await connection.ExecuteAsync(query, param);
			}
		}

		public async Task<IEnumerable<T>> Query<T>(string query, object param)
		{
			using var connection = new MySqlConnection(_connectionString);

			connection.Open();

			return await connection.QueryAsync<T>(query, param);
		}
	}
}
