using AutoMapper;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Domain.MainEntities;

namespace Project.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateCompanyRequest, Company>().ReverseMap();
		}
	}
}
