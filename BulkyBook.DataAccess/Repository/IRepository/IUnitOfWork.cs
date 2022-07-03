namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ICompanyRepository Company{ get; }
        IApplicationUserRepository ApplicationUser{ get; }
        IShoppingCartRepository ShoppingCart{ get; }
        IOrderDetailRepository OrderDetail{ get; }
        IOrderHeaderRepository OrderHeader{ get; }
        void Save();
    }
}
