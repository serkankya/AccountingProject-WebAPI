using AutoMapper;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;
using Project.Domain.CompanyEntities;
using Project.Domain.MainEntities;
using Project.Domain.MainEntities.Identity;

namespace Project.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateCompanyCommand, Company>().ReverseMap();
			CreateMap<CreateUCOACommand, UCOA>().ReverseMap();
			CreateMap<CreateRoleCommand, AppRole>().ReverseMap();
		}
	}
}
