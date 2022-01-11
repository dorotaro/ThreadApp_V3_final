using Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Configuration;

namespace Domain.Configuration
{
	public static class ConfigurationExtension
	{
		public static IServiceCollection AddDomain(this IServiceCollection service, IConfiguration configuration)
		{
			return
				service
				.AddServices()
				.AddPersistance(configuration);
		}

		public static IServiceCollection AddServices(this IServiceCollection service)
		{
			service.AddSingleton<IThreadService, ThreadService>();

			return service;
		}
	}
}
