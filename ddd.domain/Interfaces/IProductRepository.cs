using ddd.infrastructure.Interfaces;

namespace ddd.domain.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct<T>(T productspu) where T : class, IAggregationRoot;
    }
}
