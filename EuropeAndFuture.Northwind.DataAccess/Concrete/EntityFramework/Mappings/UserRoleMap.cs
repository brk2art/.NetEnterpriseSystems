using EuropeAndFuture.Northwind.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.RoleId).HasColumnName("RoleId");
            Property(x => x.UserId).HasColumnName("UserId");
        }
    }
}
