using Domain.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ThreadApp
{
	public class Program
	{

		public static IConfiguration Configuration;

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var services = new ServiceCollection();

			

			
			var builder = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

			Configuration = builder.Build();

			ConfigureServices(services, Configuration);

			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				var form1 = serviceProvider.GetRequiredService<Form1>();
				Application.Run(form1);
			}

		}

		public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<Form1>();
			services.AddDomain(configuration);
		}
	}
}
