namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IOpenCloseMenuRepository OpenCloseMenu { get; }
        IProductImageRepository ProductImage { get; }


        void Save();
    }
}
