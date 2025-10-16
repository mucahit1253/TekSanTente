using System.Linq.Expressions;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        T? FindByCondition(Expression<Func<T, bool>> exception, bool trackChanges);
        IQueryable<T> FindCondition(Expression<Func<T, bool>> exception, bool trackChanges);

    }
}
