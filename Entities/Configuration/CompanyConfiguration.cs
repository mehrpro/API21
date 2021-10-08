using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    CompanyID = 1,
                    CompanyTitle = "IranPayam",
                    Address = "Tehran",
                    Country = "IRAN",

                },
                new Company
                {
                    CompanyID = 2,
                    CompanyTitle = "SamService",
                    Address = "Tabriz",
                    Country = "IRAN",
                });
        }
    }
}