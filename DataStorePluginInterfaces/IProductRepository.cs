using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces;

public interface IProductRepository
{
    void AddProduct(Product product);
    IEnumerable<Product> GetProducts();
    Product? GetProductById(int productId, bool loadCategory);
    void UpdateProduct(int productId, Product product);
    void DeleteProduct(int productId);
}