using EuropeAndFuture.Northwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
        }
    }
}
