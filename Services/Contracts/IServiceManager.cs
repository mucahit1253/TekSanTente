namespace Services.Contracts
{
    public interface IServiceManager
    {

        IProductService ProductService { get; }
        ICategoryService CategoryService { get; }

        IOpenCloseMenuService OpenCloseMenuService { get; }
        IProductImageService ProductImageService { get; }

    }
}
