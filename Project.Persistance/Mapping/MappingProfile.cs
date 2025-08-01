using AutoMapper;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;
using Project.Domain.CompanyEntities;
using Project.Domain.MainEntities;

namespace Project.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateCompanyRequest, Company>().ReverseMap();
			CreateMap<CreateUCOARequest, UCOA>().ReverseMap();
		}
	}
}
