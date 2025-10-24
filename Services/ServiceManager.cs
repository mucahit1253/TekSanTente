using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IOpenCloseMenuService _openCloseMenuService;
        private readonly IProductImageService _productImageService;


        public ServiceManager(IProductService productService,
            ICategoryService categoryService,
            IOpenCloseMenuService openCloseMenuService
,
            IProductImageService productImageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _openCloseMenuService = openCloseMenuService;
            _productImageService = productImageService;
        }


        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

        public IOpenCloseMenuService OpenCloseMenuService => _openCloseMenuService;

        public IProductImageService ProductImageService => _productImageService;
    }
}
