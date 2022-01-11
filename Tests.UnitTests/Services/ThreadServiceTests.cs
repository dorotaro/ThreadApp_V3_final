using Domain.Services;
using FluentAssertions;
using NSubstitute;
using Persistance.Repositories;
using SharedModels.ReadModels;
using SharedModels.WriteModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Tests.UnitTests.Services
{
	public class ThreadServiceTests
	{
		private readonly IThreadService _sut;
		private readonly IThreadRepository _threadRepository;
		public ThreadServiceTests()
		{
			_threadRepository = Substitute.For<IThreadRepository>();
			_sut = new ThreadService(_threadRepository);
		}

		[Fact]
		public async Task Should_return_20_threads()
		{
			//arrange
			var threadList = ThreadReads();
			_threadRepository.GetAll<ThreadReadModel, ThreadWriteModel>().Returns(threadList);
			//act
			var result = await _sut.GetThreads();
			//assert
			result.Should().BeOfType<List<ThreadReadModel>>();
			result.Count.Should().Be(20);
			await _threadRepository.Received(1).GetAll<ThreadReadModel, ThreadWriteModel>();
		}

		private static IEnumerable<ThreadReadModel> ThreadReads()
		{
			var threadList = new List<ThreadReadModel>();
			for (var i=0;i<20;i++)
			{
				var threadReadModel = new ThreadReadModel()
				{
					ThreadID = "test"
				};
				threadList.Add(threadReadModel);
			}

			return threadList;
		}
	}
}
