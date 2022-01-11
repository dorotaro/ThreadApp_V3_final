using SharedModels.ReadModels;
using SharedModels.WriteModels;

namespace Domain.Services
{
	public interface IThreadService
	{
		Task<List<ThreadReadModel>> GetThreads();

		Task AddThread(ThreadWriteModel threadWriteModel);
	}
}
