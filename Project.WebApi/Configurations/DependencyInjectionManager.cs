using System.Reflection;

namespace Project.WebApi.Configurations
{
	public static class DependencyInjectionManager
	{
		public static IServiceCollection InstallServices(this IServiceCollection services, IConfiguration configuration, params Assembly[] assemblies)
		{
			IEnumerable<IServiceInstaller> installers = assemblies.SelectMany(x => x.DefinedTypes)
																   .Where(IsAssignableToType<IServiceInstaller>)
																   .Select(Activator.CreateInstance).
																   Cast<IServiceInstaller>();

			foreach (IServiceInstaller item in installers)
			{
				item.Install(services, configuration);
			}

			return services;

			static bool IsAssignableToType<T>(TypeInfo typeInfo) =>
					   typeof(T).IsAssignableFrom(typeInfo)
					   && !typeInfo.IsAbstract
					   && !typeInfo.IsInterface;
		}
	}
}
