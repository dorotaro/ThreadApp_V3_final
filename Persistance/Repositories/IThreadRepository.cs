namespace Persistance.Repositories
{
	public interface IThreadRepository
	{
		Task<IEnumerable<T1>> GetAll<T1, T2>();

		Task Add<T1, T2>(T2 model);
	}
}
