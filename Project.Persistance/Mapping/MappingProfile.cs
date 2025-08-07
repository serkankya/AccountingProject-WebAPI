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
			CreateMap<CreateCompanyRequest, Company>().ReverseMap();
			CreateMap<CreateUCOARequest, UCOA>().ReverseMap();
			CreateMap<CreateRoleRequest, AppRole>().ReverseMap();
		}
	}
}
