using Entities.Configuration;
using Microsoft.EntityFrameworkCore;



namespace Entities.Models
{
    public class Api21DbContext : DbContext
    {
        public Api21DbContext(DbContextOptions options) : base(options)
        {

        }


        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            modelBuilder.Entity<Employee>(opts =>
            {
                opts.HasKey(x => x.EmployeeID);
                opts.Property(x => x.EmployeeID).IsRequired().ValueGeneratedOnAdd();
                opts.Property(x => x.FullName).HasMaxLength(150).IsRequired();
                opts.Property(x => x.Position).HasMaxLength(250);
                opts.HasOne<Company>(x => x.Company)
                    .WithMany(x => x.Employees)
                    .HasForeignKey(x => x.CompanyID_FK)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Company>(opts =>
            {
                opts.HasKey(x => x.CompanyID);
                opts.Property(x => x.CompanyID).IsRequired().ValueGeneratedOnAdd();
                opts.Property(x => x.Address).HasMaxLength(250);
                opts.Property(x => x.CompanyTitle).HasMaxLength(250).IsRequired();
                opts.Property(x => x.Country).HasMaxLength(150);
            });
        }
    }
}