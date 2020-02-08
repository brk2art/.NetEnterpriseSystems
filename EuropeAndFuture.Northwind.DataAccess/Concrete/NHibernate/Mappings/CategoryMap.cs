using FluentNHibernate.Mapping;
using EuropeAndFuture.Northwind.Entities.Concrete;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryID");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
