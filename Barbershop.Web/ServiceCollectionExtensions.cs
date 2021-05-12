using Microsoft.Extensions.DependencyInjection;

namespace Barbershop.Web
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddDomainLogic(this IServiceCollection services)
		{
			return services
				.AddScoped<IUserService, UserService>()
				;
		}
	}
}