using Persistance.Clients;
namespace Persistance.Repositories
{
	public class ThreadRepository : IThreadRepository
	{
		private readonly ISqlClient _sqlClient;

		private readonly string tableName = "threads_repository";
		public ThreadRepository(ISqlClient sqlClient)
		{
			_sqlClient = sqlClient;
		}

		public async Task<IEnumerable<T1>> GetAll<T1,T2>()
		{
			var query = $"SELECT * FROM {tableName}";

			return await _sqlClient.Query<T1>(query, null);
		}

		public async Task Add<T1,T2>(T2 model)
		{

			var query = $"INSERT INTO {tableName} (ThreadID, Data,TimeCreated) VALUES (@ThreadID,@Data,@Time)";

			var queries = new List<string>();

			queries.Add(query);

			await _sqlClient.Execute<T1>(queries, model);

		}
	}
}
