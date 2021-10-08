using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    EmployeeID = 1,
                    FullName = "Farshid Mohammadi",
                    Position = "IT Administrator",
                    Age = 35,
                    CompanyID_FK = 1,
                },
                new Employee
                {
                    EmployeeID = 2,
                    FullName = "Sara Ahamadi",
                    Position = "Manager",
                    Age = 45,
                    CompanyID_FK = 2,
                });
        }
    }
}