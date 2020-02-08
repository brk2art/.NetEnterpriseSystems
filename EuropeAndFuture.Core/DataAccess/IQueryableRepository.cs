using System.Linq;

namespace EuropeAndFuture.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
