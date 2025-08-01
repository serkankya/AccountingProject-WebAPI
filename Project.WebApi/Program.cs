using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Project.Application.Services.AppServices;
using Project.Domain;
using Project.Domain.MainEntities.Identity;
using Project.Persistance;
using Project.Persistance.Context;
using Project.Persistance.Services.AppServices;

namespace Project.WebApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<AppDbContext>(opt => 
					opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

			builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<AppDbContext>();

			builder.Services.AddScoped<ICompanyService, CompanyService>();
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

			builder.Services.AddMediatR(cfg => 
				cfg.RegisterServicesFromAssembly(typeof(Application.AssemblyReference).Assembly));

			builder.Services.AddAutoMapper(typeof(Persistance.AssemblyReference).Assembly);

			// Add services to the container.

			builder.Services.AddControllers().AddApplicationPart(typeof(Project.Presentation.AssemblyReference).Assembly);
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();

			builder.Services.AddSwaggerGen(setup =>
			{
				var jwtSecuritySheme = new OpenApiSecurityScheme
				{
					BearerFormat = "JWT",
					Name = "JWT Authentication",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.Http,
					Scheme = JwtBearerDefaults.AuthenticationScheme,
					Description = "Put **_ONLY_** yourt JWT Bearer token on textbox below!",

					Reference = new OpenApiReference
					{
						Id = JwtBearerDefaults.AuthenticationScheme,
						Type = ReferenceType.SecurityScheme
					}
				};

				setup.AddSecurityDefinition(jwtSecuritySheme.Reference.Id, jwtSecuritySheme);

				setup.AddSecurityRequirement(new OpenApiSecurityRequirement
	{
		{ jwtSecuritySheme, Array.Empty<string>() }
	});
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
