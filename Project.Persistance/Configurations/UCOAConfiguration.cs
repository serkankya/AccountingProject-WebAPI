using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain.CompanyEntities;
using Project.Persistance.Constants;

namespace Project.Persistance.Configurations
{
	public sealed class UCOAConfiguration : IEntityTypeConfiguration<UCOA>
	{
		public void Configure(EntityTypeBuilder<UCOA> builder)
		{
			builder.ToTable(TableNames.UCOAs);
			builder.HasKey(x => x.Id);
		}
	}
}
