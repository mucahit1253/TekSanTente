using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Category> GetAllCategory(bool trackChanges) => FindAll(false);

        public Category? GetOneCategory(int id, bool trackChanges)
        {
            return FindByCondition(p => p.Slug.Equals(id), trackChanges);
        }
    }
}
