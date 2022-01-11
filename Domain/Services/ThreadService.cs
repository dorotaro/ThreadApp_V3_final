using Persistance.Repositories;
using SharedModels.ReadModels;
using SharedModels.WriteModels;

namespace Domain.Services
{
	public class ThreadService : IThreadService
	{
		private readonly IThreadRepository _threadRepository;

		public ThreadService(IThreadRepository threadRepository)
		{
			_threadRepository = threadRepository;
		}
		public async Task AddThread(ThreadWriteModel threadWriteModel)
		{
			await _threadRepository.Add<ThreadReadModel, ThreadWriteModel>(threadWriteModel);
		}

		public async Task<List<ThreadReadModel>> GetThreads()
		{
			var threads = await _threadRepository.GetAll<ThreadReadModel, ThreadWriteModel>();

			var last20 = threads.Skip(0).TakeLast(20);

			return last20.ToList();
		}
	}
}
