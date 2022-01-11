using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Clients;
using Persistance.Repositories;

namespace Persistance.Configuration
{
	public static class ConfigurationExtension
	{
		public static IServiceCollection AddPersistance(this IServiceCollection service, IConfiguration configuration)
		{
			return service
					.AddRepositories()
					.AddClients(configuration);
		}

		public static IServiceCollection AddRepositories(this IServiceCollection service)
		{
			return service
				.AddTransient<IThreadRepository, ThreadRepository>();
		}

		public static IServiceCollection AddClients(this IServiceCollection service, IConfiguration configuration)
		{
			var connectionString = configuration.GetSection("ConnectionStrings")["SqlConnectionString"];

			return service
				.AddTransient<ISqlClient>(_ => new SqlClient(connectionString));
		}
	}
}
