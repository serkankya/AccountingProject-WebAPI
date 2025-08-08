using Microsoft.AspNetCore.Identity;
using Project.Domain.MainEntities.Identity;
using Project.WebApi.Configurations;
using Project.WebApi.Middleware;

namespace Project.WebApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);

			var app = builder.Build();

			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseExceptionMiddleware();

			app.UseHttpsRedirection();

			app.UseAuthentication();

			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
	}
}
