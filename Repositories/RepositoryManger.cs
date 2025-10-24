using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManger : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOpenCloseMenuRepository _openCloseMenuRepository;
        private readonly IProductImageRepository _productImageRepository;


        public RepositoryManger(IProductRepository productRepository,
            RepositoryContext context,
            ICategoryRepository categoryRepository,
            IOpenCloseMenuRepository openCloseMenuRepository,
            IProductImageRepository productImageRepository)
        {
            _productRepository = productRepository;
            _context = context;
            _categoryRepository = categoryRepository;
            _openCloseMenuRepository = openCloseMenuRepository;
            _productImageRepository = productImageRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public IOpenCloseMenuRepository OpenCloseMenu => _openCloseMenuRepository;

        public IProductImageRepository ProductImage => _productImageRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
